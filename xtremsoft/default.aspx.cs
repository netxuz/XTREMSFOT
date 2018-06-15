using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using xtremsoft.webmethod;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace xtremsoft
{
  public partial class _default : System.Web.UI.Page
  {
    cWeb oWeb = new cWeb();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void valtxtEmailVal_ServerValidate(object source, ServerValidateEventArgs args)
    {
      try
      {
        args.IsValid = oWeb.ValidaMail(args.Value);
      }
      catch
      {
        args.IsValid = false;
      }
    }

    protected void btnEnviarMsn_Click(object sender, EventArgs e)
    {
      StringBuilder sHtml = new StringBuilder();
      sHtml.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
      sHtml.Append("<head>");
      sHtml.Append("<title></title>");
      sHtml.Append("<style>");
      sHtml.Append("body {margin: 0px !important;font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;}");
      sHtml.Append(".tablasup {width: 100%; align-content: center;}");
      sHtml.Append(".tablainf {width: 600px;}");
      sHtml.Append(".titulo { height: 150px;text-align: center;color: #fff;background-color: #FE6311;margin-bottom: 5px;}");
      sHtml.Append(".linea { background-color: #d4cfcf; height: 1px;}");
      sHtml.Append(".subtitulo { text-align:center; height: 50px; margin-bottom: 5px; color:#b7acac;}");
      sHtml.Append(".detalle { color:#b7acac; padding-left:10px; padding-top:10px; padding-bottom:10px; }");
      sHtml.Append("</style>");
      sHtml.Append("</head>");
      sHtml.Append("<body>");
      sHtml.Append("<table border=\"0\" class=\"tablasup\" align=\"center\">");
      sHtml.Append("<tr><td>");
      sHtml.Append("<table border=\"0\" class=\"tablainf\">");
      sHtml.Append("<tr><td class=\"titulo\"><b>Mail de contacto desde<br />XTREMSOFT</b></td></tr>");
      sHtml.Append("<tr><td><hr class=\"linea\" /></td></tr>");
      sHtml.Append("<tr><td class=\"subtitulo\"><b>Datos del contacto</b></td></tr>");
      sHtml.Append("<tr><td class=\"detalle\"><b>Nombre:</b> [NOMBRE]</td></tr>");
      sHtml.Append("<tr><td class=\"detalle\"><b>Email:</b> [EMAIL]</td></tr>");
      sHtml.Append("<tr><td class=\"detalle\"><b>Celular:</b> [CELULAR]</td></tr>");
      sHtml.Append("<tr><td class=\"detalle\"><b>Mensaje:</b> [MENSAJE]</td></tr>");
      sHtml.Append("</table>");
      sHtml.Append("</td></tr>");
      sHtml.Append("</table>");
      sHtml.Append("</body>");
      sHtml.Append("</html>");

      sHtml.Replace("[NOMBRE]", txtNombre.Text);
      sHtml.Replace("[EMAIL]", txtEmail.Text);
      sHtml.Replace("[CELULAR]", txtFono.Text);
      sHtml.Replace("[MENSAJE]", txtComentario.Text);

      var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
      var client = new SendGridClient(apiKey);
      var msg = new SendGridMessage()
      {
        From = new EmailAddress("xtremsoftchile@gmail.com", "XTREMSOFT Team"),
        Subject = "Notificación de contacto desde sitio Xtremsoft",
        //PlainTextContent = "Hello, Email!",
        HtmlContent = sHtml.ToString()
      };
      msg.AddTo(new EmailAddress("xtremsoftchile@gmail.com", "XTREMSOFT"));
      msg.AddCc(new EmailAddress("camidelsolar16@gmail.com", "Camila Del Solar"));
      msg.AddCc(new EmailAddress("crisescobarm@gmail.com", "Cristian Escobar"));
      var response = client.SendEmailAsync(msg);

      //response.Result.ToString();

      msj.Visible = true;
      idnombre.Visible = false;
      idemail.Visible = false;
      idfono.Visible = false;
      idcomentario.Visible = false;
      idbtnenviar.Visible = false;
      idbtnclose.Visible = true;
      btncloseup.Visible = false;
      //msj.Controls.Add(new LiteralControl("Su mensaje ha sido enviado..." + response.Result.ToString()));


    }

    protected void btnCloseMsn_Click(object sender, EventArgs e)
    {
      msj.Visible = false;

      idnombre.Visible = true;
      txtNombre.Text = string.Empty;

      idemail.Visible = true;
      txtEmail.Text = string.Empty;

      idfono.Visible = true;
      txtFono.Text = string.Empty;

      idcomentario.Visible = true;
      txtComentario.Text = string.Empty;

      idbtnenviar.Visible = true;
      btncloseup.Visible = true;
      idbtnclose.Visible = false;

      //UpdatePanel1.Update();

      ScriptManager.RegisterStartupScript(this, typeof(string), "hide", "$(function () { $('#myModal').modal('hide'); });", true);

      //this.ClientScript.RegisterStartupScript(this.GetType(), "hide", "$(function () { $('#myModal').modal('hide'); });", true);
    }
  }
}