<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="xtremsoft._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta http-equiv="x-ua-compatible" content="ie=edge">
  <title>Desarrollo y diseño de Páginas Web - XtremSoft</title>
  <link href="/images/favicon.ico?t=20170805" type="image/x-icon" rel="icon" />
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.0/css/font-awesome.min.css">
  <!-- Bootstrap core CSS -->
  <link href="css/bootstrap.min.css" rel="stylesheet">
  <!-- Material Design Bootstrap -->
  <link href="css/mdb.min.css" rel="stylesheet">
  <link href="css/style.css" rel="stylesheet">
</head>
<body>
  <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
    <header>

      <!--Navbar-->
      <nav class="navbar fixed-top navbar-toggleable-md scrolling-navbar navbar-dark">
        <div class="container">
          <img id="logocolor" src="/images/logo.png" class="navbar-brand" />
          <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarNav1" aria-controls="navbarNav1" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarNav1">
            <ul class="navbar-nav mr-auto">
              <li class="nav-item">
                <a class="nav-link" href="#home">HOME <span class="sr-only">(current)</span></a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#loquehacemos">LO QUE HACEMOS</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#requerimientosespecificos">SERVICIOS</a>
              </li>
            </ul>
            <button type="button" class="btn btn-contactanos" data-toggle="modal" data-target="#myModal"><span class="fa fa-phone"></span>&nbsp;CONTÁCTANOS</button>
          </div>
        </div>
      </nav>
      <!--/.Navbar-->

    </header>
    <main>
      <div class="view banner01" id="home">
        <div class="full-bg-img flex-center">
          <div class="row mt-5 py-5">
            <div class="col-md-12 col-sm-12 text-center">
              <h2 class="labeltitle wow animated fadeInLeft" data-wow-duration="2s" data-wow-delay="0.8s">Tú empresa aún no tiene sitio web?</h2>
            </div>
          </div>
        </div>
      </div>

      <div class="view banner03 hm-black-light">
        <div class="full-bg-img">
          <div class="container">
            <div class="row mt-3 py-1">
              <div class="col-md-12 col-sm-12 text-center">
                <h4 class="labeltitlewhite text-uppercase wow animate fadeIn" data-wow-duration="4s" data-wow-delay="0.05s">No sabes como?<br />
                  No te preocupes, nosotros te ayudamos.<br />
                  <br />
                </h4>
              </div>
            </div>
            <div class="row mt-1 py-1">
              <div class="col-md-12 col-sm-12 text-center">
                <h4 class="labeldatawhite wow animated fadeIn" data-wow-duration="4s" data-wow-delay="0.05s">Teniendo página web, tu negocio siempre estará disponible para tus clientes, las 24 horas del día, los 7 días de la semana, entregando la información de tus productos y servicios en el momento que se necesiten.</h4>
              </div>
            </div>
          </div>
        </div>
      </div>

      <section class="bannerservicios" id="loquehacemos">
        <div class="container">
          <div class="row">
            <div class="col-md-12 col-sm-12">
              <h4 class="labeltitleblack mt-3 py-1 wow animate text-warning text-uppercase text-center">nuestros servicios consideran</h4>
              <div class="row py-3">
                <div class="container">
                  <div class="row align-items-start justify-content-center">
                    <div class="col-md-6 col-sm-6">

                      <ul class="labeldatablack">
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.6s"><span class="fa fa-tablet"></span> Desarrollo sitio web responsivo (Web Mobile)</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.8s"><span class="fa fa-android"></span> Desarrollo de App</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.10s"><span class="fa fa-shopping-cart"></span> Catálogo de Productos / Carrito de compras</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.4s"><span class="fa fa-pencil-square-o"></span> Administración de contenidos</li>

                      </ul>

                    </div>

                    <div class="col-md-6 col-sm-6">
                      <ul class="labeldatablack">
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.2s"><span class="fa fa-server"></span> Hosting por 12 meses</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.8s"><span class="fa fa-cog"></span> Soporte</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.6s"><span class="fa fa-envelope-o"></span> Cuentas Email</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.4s"><span class="fa fa-bar-chart"></span> Google Analitycs</li>
                      </ul>
                    </div>
                  </div>

                </div>
              </div>
            </div>
          </div>

        </div>
      </section>

      <div class="view banner02 hm-black-light">
        <div class="full-bg-img">
          <div class="row mt-3 py-3">
            <div class="col-md-12 col-sm-12 text-center">
              <h4 class="labeltitlewhite text-uppercase wow animated fadeInLeft" data-wow-duration="4s" data-wow-delay="0.05s">¿Tienes requerimientos más complejos?<br />
                ¡NOSOTROS LOS HACEMOS POR TI!
              </h4>
            </div>
          </div>
          <div class="row mt-2 py-2">
            <div class="col-md-12 col-sm-12 text-center">
              <div class="container">
                <h4 class="labeldatawhite wow animated fadeInLeft" data-wow-duration="4s" data-wow-delay="0.05s">Tenemos 17 años de experiencia en ingeniería de software, esto nos permite entregar un producto con valor agregado y personalizado a nuestros clientes.</h4>
              </div>
            </div>
          </div>
        </div>

      </div>

      <section class="bannerservicios" id="requerimientosespecificos">
        <div class="container">
          <div class="row">
            <div class="col-md-12 col-sm-12">
              <h4 class="labeltitleblack mt-3 py-1 wow animate text-warning text-uppercase text-center">Servicios específicos, según tus necesidades</h4>

              <div class="row mt-1 py-1">
                <div class="container">
                  <div class="row align-items-start justify-content-center">
                    <div class="col-md-6 col-sm-6">
                      <ul class="labeldatablack">
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.6s"><span class="fa fa-link"></span> Integración con Web Pay / Kiphu.</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.8s"><span class="fa fa-line-chart"></span> Sistema de reportes y estadísticas.</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.6s"><span class="fa fa-briefcase"></span> Portal de Licenciatarios.</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.4s"><span class="fa fa-puzzle-piece"></span> Sistema de Campañas.</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.2s"><span class="fa fa-book"></span> Gestión documental.</li>
                      </ul>
                    </div>
                    <div class="col-md-6 col-sm-6">
                      <ul class="labeldatablack">
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.10s"><span class="fa fa-cogs"></span> Sistemas BPM.</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.8s"><span class="fa fa-life-ring"></span> Sistemas HelpDesk.</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.6s"><span class="fa fa-link"></span> Integración de sistemas.</li>
                        <li class="wow animated fadeInRight" data-wow-duration="2s" data-wow-delay="0.4s"><span class="fa fa-cloud"></span> Google Adwords.</li>
                      </ul>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>

        </div>
      </section>

      <section class="blqsup_producto">
        <div class="container">
          <div class="row">
            <div class="col-md-4 col-sm-4">
              <div class="bloque_producto text-center">
                <img id="logomsazure" src="/images/logomsazure.png" class="img-responsive wow animated fadeIn" data-wow-duration="2s" data-wow-delay="0.8s" />
              </div>
            </div>
            <div class="col-md-4 col-sm-4">
              <div class="bloque_producto text-center">
                <img id="logovs" src="/images/logovs.png" class="img-responsive wow animated fadeIn" data-wow-duration="2s" data-wow-delay="0.8s" />
              </div>
            </div>
            <div class="col-md-4 col-sm-4">
              <div class="bloque_producto text-center">
                <img id="lgosql" src="/images/lgosql.png" class="img-responsive wow animated fadeIn" data-wow-duration="2s" data-wow-delay="0.8s" />
              </div>
            </div>
          </div>
        </div>
      </section>

    </main>



    <footer class="view banner04 hm-stylish-strong">
      <div class="full-bg-img">
        <div class="container">
          <div class="row mt-1 py-1">
            <div class="col-md-6 col-sm-6">
              <div class="contact-info-box address clearfix">
                <h3><em class="fa fa-map-marker"></em>Dirección :</h3>
                <span class="white-text">Pimpinela #57,
                  <br>
                  Machali, Rancagua, Chile.</span>
              </div>
              <div class="contact-info-box phone clearfix">
                <h3><em class="fa fa-phone"></em>Fono :</h3>
                <span class="white-text">+569 7770 8896</span>
              </div>
              <%--<div class="contact-info-box email clearfix">
                <h3><em class="fa fa-envelope"></em>email :</h3>
                <span class="white-text"><a href="maito:contacto@xtremsoft.cl" class="white-text">contacto@xtremsoft.cl</a></span>
              </div>--%>
            </div>
            <div class="col-md-6 col-sm-6 text-right">
              <ul class="inline-list">
                <li><a class="fa fa-facebook" href="https://www.facebook.com/xtremsoft.cl" target="_blank"></a></li>
                <li><a class="fa fa-twitter" href="https://twitter.com/xtremsoftchile" target="_blank"></a></li>
                <li><a class="fa fa-linkedin" href="https://www.linkedin.com/company-beta/25010771/" target="_blank"></a></li>
                <%--<li><a class="fa fa-instagram" href="#"></a></li>--%>
                <%--<li><a class="fa fa-youtube" href="#"></a></li>--%>
              </ul>
            </div>
          </div>
        </div>
        <!--Copyright-->
        <div class="footer-copyright">
          <div class="container-fluid text-center text-white text-uppercase">
            © 2017 Copyright <a href="https://www.xtremsoft.cl" class="text-warning">Xtremsoft.cl</a>

          </div>
        </div>
        <!--/.Copyright-->
      </div>
    </footer>


    <!--Modal: Contact form-->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
      <div class="modal-dialog cascading-modal" role="document">
        <!--Content-->
        <div class="modal-content">
          <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
              <!--Header-->
              <div class="modal-header light-green darken-3 white-text">
                <button type="button" id="btncloseup" runat="server" visible="true" class="close waves-effect waves-light" data-dismiss="modal" aria-label="Close">
                  <span aria-hidden="true">&times;</span>
                </button>
                <h4 class="title"><i class="fa fa-pencil"></i>Contáctanos</h4>
              </div>
              <!--Body-->
              <div class="modal-body mb-0">
                <div id="msj" runat="server" class="alert alert-warning" visible="false">
                  <strong>ATENCIÓN</strong> Su correo fue enviado correctamente, pronto nos comunicaremos con Usted.
                </div>

                <div class="md-form form-sm" id="idnombre" runat="server" visible="true">
                  <i class="fa fa-envelope prefix"></i>
                  <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                  <label for="form19">Tu nombre</label>
                  <asp:RequiredFieldValidator ID="valNombre" runat="server" ControlToValidate="txtNombre" Display="Static" ErrorMessage="*"></asp:RequiredFieldValidator>
                </div>

                <div class="md-form form-sm" id="idemail" runat="server" visible="true">
                  <i class="fa fa-lock prefix"></i>
                  <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                  <label for="form20">Tu email</label>
                  <asp:RequiredFieldValidator ID="valEmail" runat="server" ControlToValidate="txtEmail" Display="Static" ErrorMessage="*"></asp:RequiredFieldValidator>
                  <asp:CustomValidator ID="valtxtEmailVal" runat="server"
                    ErrorMessage="El correo ingresado no tiene el formato correcto"
                    ControlToValidate="txtEmail" ClientValidationFunction="validateEmail"></asp:CustomValidator>
                </div>

                <div class="md-form form-sm" id="idfono" runat="server" visible="true">
                  <i class="fa fa-phone prefix"></i>
                  <asp:TextBox ID="txtFono" runat="server" CssClass="form-control"></asp:TextBox>
                  <label for="form21">Tu celular</label>
                </div>

                <div class="md-form form-sm" id="idcomentario" runat="server" visible="true">
                  <i class="fa fa-pencil prefix"></i>
                  <asp:TextBox ID="txtComentario" runat="server" TextMode="MultiLine" CssClass="md-textarea mb-0" Rows="7" Columns="40"></asp:TextBox>
                  <label for="form8">Tu mensaje</label>
                  <asp:RequiredFieldValidator ID="valComentario" runat="server" ControlToValidate="txtComentario" Display="Static" ErrorMessage="*"></asp:RequiredFieldValidator>
                </div>

                <div class="text-center mt-1-half" id="idbtnenviar" runat="server" visible="true">
                  <asp:Button ID="btnEnviarMsn" runat="server" CssClass="btn btn-orange mb-2 fa fa-send ml-1" Text="&nbsp;Enviar" OnClick="btnEnviarMsn_Click" />
                </div>

                <div class="text-center mt-1-half" id="idbtnclose" runat="server" visible="false">
                  <asp:Button ID="btnCloseMsn" runat="server" CssClass="btn btn-orange mb-2 fa fa-close ml-1" Text="&nbsp;Cerrar" OnClick="btnCloseMsn_Click" />
                </div>

              </div>
              <!--/.Content-->
            </ContentTemplate>
          </asp:UpdatePanel>
        </div>
      </div>
    </div>
    <!--Modal: Contact form-->
  </form>



  <!-- SCRIPTS -->
  <!-- JQuery -->
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
  <!-- googleapis -->
  <script type="text/javascript" src="js/jquery-3.1.1.min.js"></script>
  <!-- Bootstrap tooltips -->
  <script type="text/javascript" src="js/tether.min.js"></script>
  <!-- Bootstrap core JavaScript -->
  <script type="text/javascript" src="js/bootstrap.min.js"></script>
  <!-- MDB core JavaScript -->
  <script type="text/javascript" src="js/mdb.min.js"></script>
  <script>
    function validateEmail(oSrc, args) {
      var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
      args.IsValid = re.test(args.Value);
    }
    wow = new WOW({
      boxClass: 'wow', // default
      animateClass: 'animated', // default
      offset: 0, // default
      mobile: true, // default
      live: true // default
    })
    wow.init();

    $('#myModal').on('hidden.bs.modal', function (e) {
      $(this)
        .find("input[type=text],textarea,select")
           .val('')
           .end()
        .find("input[type=checkbox], input[type=radio]")
           .prop("checked", "")
           .end();
    })
  </script>
  <script>
    (function (i, s, o, g, r, a, m) {
      i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
        (i[r].q = i[r].q || []).push(arguments)
      }, i[r].l = 1 * new Date(); a = s.createElement(o),
      m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
    })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

    ga('create', 'UA-104614917-1', 'auto');
    ga('send', 'pageview');

  </script>
</body>
</html>
