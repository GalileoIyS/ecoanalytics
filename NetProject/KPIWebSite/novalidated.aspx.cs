﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class novalidated : System.Web.UI.Page
{
    #region Variables Privadas del Formulario
    private int? usuarioid
    {
        get
        {
            object o = ViewState["usuarioid"];
            if (o == null)
                return null;
            else
                return (int)o;
        }
        set
        {
            ViewState["usuarioid"] = value;
        }
    }
    #endregion

    #region Eventos de los controles del formulario
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["userid"]))
            {
                using (Clases.cASPNET_INFO_USUARIO objUsuario = new Clases.cASPNET_INFO_USUARIO())
                {
                    objUsuario.userid = Convert.ToInt32(Request.QueryString["userid"]);
                    if (objUsuario.bConsultar())
                    {
                        this.usuarioid = objUsuario.userid;
                        lbFirstAndLastName.Text = objUsuario.nombre + " " + objUsuario.apellidos;
                    }
                    else
                        Response.Redirect("~/errors/notfound.aspx");
                }
            }
        }
    }
    private void Page_Error(object sender, EventArgs e)
    {
        // Obtenemos el último error del servidor.
        Exception exc = Server.GetLastError();

        // Controlamos esta específica excepción
        if (exc is InvalidOperationException)
        {
            // Enviamos la información del error a la página de errores
            Server.Transfer("~/errors/customerror.aspx?handler=Page_Error%20-%novalidated.aspx",
                true);
        }
    }
    #endregion

    #region Botones de Accion
    protected void btnSendCode_Click(object sender, EventArgs e)
    {
        if (!usuarioid.HasValue)
            return;

        MembershipUser Usuario = Membership.GetUser(usuarioid, false);
        if (Usuario != null)
        {
            string validationCode = new Random().Next().ToString();

            //1.-Destino del mensaje
            System.Net.Mail.MailAddressCollection MisDestinos = new System.Net.Mail.MailAddressCollection();
            MisDestinos.Add(new System.Net.Mail.MailAddress(Usuario.Email));

            //2.-Cuerpo del mensaje
            HttpServerUtility server = HttpContext.Current.Server;
            string sMensaje = "We have sucessfully received your registration request to DropKeys. To complete the subscription process, please click the following link :\r\n\r\n " + Request.Url.GetLeftPart(UriPartial.Authority) + "/validatecode.aspx?email=" +
                server.UrlEncode(Usuario.Email) + "&vc=" + validationCode + "\r\n\r\nThank you.";

            if (EmailUtils.SendMessageEmail(MisDestinos, "Verify your email", sMensaje))
            {
                using (Clases.cASPNET_INFO_USUARIO objUsuario = new Clases.cASPNET_INFO_USUARIO())
                {
                    objUsuario.userid = usuarioid;
                    if (objUsuario.bConsultar())
                    {
                        objUsuario.mensaje_validacion = true;
                        objUsuario.validado = false;
                        objUsuario.codigo_validacion = validationCode;
                        objUsuario.bModificar();
                    }
                }
            }
        }
    }
    #endregion
}