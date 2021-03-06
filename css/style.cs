@charset "UTF-8";
* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
body {
  display: grid;
  grid-template-columns: 1fr;
  grid-template-rows: auto auto auto;
  grid-template-areas: "header" "main" "footer";
}

header {
  z-index: 3;
  grid-area: header;
  width: 100vw;
  background-color: #0533ed;
}
header nav div a img {
  width: 250px;
  padding-left: 6vw;
}
@media only screen and (max-width: 768px) {
  header nav div a img {
    width: 350px;
  }
}
header nav div div {
  justify-content: flex-end;
  padding-right: 20px;
}

.menu-shadow {
  box-shadow: 0 3px 10px 0.1px rgba(0, 0, 0, 0.45);
}

* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
.alq-search div button, #header-index .header-container .search-bar .elements button, #header-index .header-container .welcome-container .welcome-container-title button {
  background: #2cd4d9;
  min-width: 120px;
  height: 35px;
  color: #0533ed;
  border: solid 2px #fff;
  border-radius: 30px;
  transition-duration: 0.6s;
}
.alq-search div button:hover, #header-index .header-container .search-bar .elements button:hover, #header-index .header-container .welcome-container .welcome-container-title button:hover {
  background: #fff;
  border: solid 3px #2cd4d9;
  box-shadow: inset 0 0 10px 0.3px #0533ed;
  transition-duration: 0.6s;
}
@media only screen and (max-width: 768px) {
  .alq-search div button, #header-index .header-container .search-bar .elements button, #header-index .header-container .welcome-container .welcome-container-title button {
    font-size: 24px;
    height: 45px;
    min-width: 240px;
  }
}

.alq-main .alq-container .alq-container-desc .alq-container-btn {
  background: #0533ed;
  width: 180px;
  height: 35px;
  color: #fff;
  border: solid 2px #fff;
  margin: 15px 25px 15px 0;
  border-radius: 30px;
}
.alq-main .alq-container .alq-container-desc .alq-container-btn:hover {
  background: #fff;
  color: #0533ed;
  border: solid 3px #0533ed;
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-desc .alq-container-btn {
    font-size: 24px;
    padding: 0 30px;
    margin: 20px 0;
    width: 70%;
    height: 50px;
  }
}

main .account .account-container .account-login .account-form button, main .account .account-container .account-signup .account-form button {
  background: #fff;
  padding: 5px 10px;
  height: 35px;
  color: #0533ed;
  border: solid 2px #fff;
  border-radius: 30px;
  margin-top: 15px;
  transition-duration: 0.6s;
  box-shadow: 0 3px 10px 0.1px rgba(0, 0, 0, 0.42);
}
main .account .account-container .account-login .account-form button:hover, main .account .account-container .account-signup .account-form button:hover {
  letter-spacing: 0.2em;
  transition-duration: 0.6s;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-login .account-form button, main .account .account-container .account-signup .account-form button {
    height: 50px;
    font-size: 24px;
    margin: 50px 25% 0 25%;
    width: 50%;
  }
}

#header-index {
  align-items: center;
  min-height: 100px;
  background-image: url(.././src/images/carnaval.jpg);
  /*Imagen de fondo del Header*/
  background-size: cover;
  background-position: center;
}
#header-index .header-container {
  /*Creamos este cotainer para agregar una capa de color sobre la imagen del Header*/
  background-image: linear-gradient(#0533ed, rgba(5, 51, 237, 0.7));
}
#header-index .header-container .nav-position {
  justify-content: flex-end;
  padding-right: 20px;
}
#header-index .header-container .welcome-container {
  color: #fff;
  display: flex;
  justify-content: center;
}
#header-index .header-container .welcome-container .welcome-container-title {
  width: 70%;
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
  word-wrap: break-word;
  padding-top: 70px;
}
@media only screen and (max-width: 768px) {
  #header-index .header-container .welcome-container .welcome-container-title {
    padding-top: 40px;
    width: 80%;
  }
}
#header-index .header-container .welcome-container .welcome-container-title h1 {
  padding-bottom: 15px;
}
@media only screen and (max-width: 768px) {
  #header-index .header-container .welcome-container .welcome-container-title p {
    font-size: 20px;
  }
}
#header-index .header-container .welcome-container .welcome-container-title button {
  margin-top: 25px;
  padding: 0 15px;
}
#header-index .header-container .search-bar {
  display: flex;
  justify-content: center;
  width: 100%;
  margin-top: 50px;
  padding-bottom: 120px;
}
@media only screen and (max-width: 768px) {
  #header-index .header-container .search-bar {
    padding: 0 20px 50px 20px;
    box-sizing: border-box;
  }
}
#header-index .header-container .search-bar .elements {
  width: 800px;
  display: flex;
  justify-content: space-between;
}
@media only screen and (max-width: 768px) {
  #header-index .header-container .search-bar .elements {
    flex-direction: column;
    width: 100%;
  }
}
#header-index .header-container .search-bar .elements .search-items {
  height: 35px;
  width: 200px;
  border-radius: 6px;
  border: none;
  text-align: center;
}
@media only screen and (max-width: 768px) {
  #header-index .header-container .search-bar .elements .search-items {
    width: 100%;
    margin-bottom: 8px;
    font-size: 20px;
    height: 50px;
  }
}
footer {
  z-index: 1;
  grid-area: footer;
  display: grid;
  grid-template-columns: repeat(4, 25%);
  grid-template-rows: auto;
  grid-template-areas: "social columna2 columna3 columna4";
  justify-content: space-between;
  width: 100%;
  min-height: 200px;
  background: #0533ed;
}
footer .footer-social {
  grid-area: social;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  align-items: center;
  margin-top: 25px;
}
footer .footer-social .logo-footer {
  width: 250px;
}
@media only screen and (max-width: 768px) {
  footer .footer-social .logo-footer {
    width: 400px;
    margin-top: 12px;
  }
}
footer .footer-social .social-media {
  display: flex;
  justify-content: space-around;
  padding-top: 15px;
  width: 40%;
}
footer .footer-social .social-media img {
  width: 25px;
}
footer .footer-column {
  display: flex;
  justify-content: center;
  align-items: flex-start;
  margin: 25px 0;
}
footer .footer-column ul {
  list-style: none;
  width: 100%;
}
footer .footer-column ul li {
  margin-bottom: 6px;
}
footer .footer-column ul li a {
  text-decoration: none;
  font-size: 13px;
  color: #fff;
  font-weight: 500;
}
footer .footer-column ul li a:hover {
  font-size: 14px;
}
@media only screen and (max-width: 768px) {
  footer .footer-column ul li a {
    font-size: 20px;
  }
}
@media only screen and (max-width: 768px) {
  footer .footer-column ul {
    padding-left: 0;
  }
}
@media only screen and (max-width: 768px) {
  footer .footer-column {
    text-align: center;
    margin: 0;
  }
}
@media only screen and (max-width: 768px) {
  footer {
    padding: 20px 0px;
    grid-template-rows: auto auto auto auto;
    grid-template-columns: 1fr;
    grid-template-areas: "social" "columna2" "columna3" "columna4";
    height: auto;
  }
}

.footer-column2 {
  grid-area: columna2;
}
@media only screen and (max-width: 768px) {
  .footer-column2 {
    margin-top: 30px !important;
  }
}

.footer-column3 {
  grid-area: columna3;
}

.footer-column4 {
  grid-area: columna4;
}

* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
.alq-search div button, #header-index .header-container .welcome-container .welcome-container-title button, #header-index .header-container .search-bar .elements button {
  background: #2cd4d9;
  min-width: 120px;
  height: 35px;
  color: #0533ed;
  border: solid 2px #fff;
  border-radius: 30px;
  transition-duration: 0.6s;
}
.alq-search div button:hover, #header-index .header-container .welcome-container .welcome-container-title button:hover, #header-index .header-container .search-bar .elements button:hover {
  background: #fff;
  border: solid 3px #2cd4d9;
  box-shadow: inset 0 0 10px 0.3px #0533ed;
  transition-duration: 0.6s;
}
@media only screen and (max-width: 768px) {
  .alq-search div button, #header-index .header-container .welcome-container .welcome-container-title button, #header-index .header-container .search-bar .elements button {
    font-size: 24px;
    height: 45px;
    min-width: 240px;
  }
}

.alq-main .alq-container .alq-container-desc .alq-container-btn {
  background: #0533ed;
  width: 180px;
  height: 35px;
  color: #fff;
  border: solid 2px #fff;
  margin: 15px 25px 15px 0;
  border-radius: 30px;
}
.alq-main .alq-container .alq-container-desc .alq-container-btn:hover {
  background: #fff;
  color: #0533ed;
  border: solid 3px #0533ed;
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-desc .alq-container-btn {
    font-size: 24px;
    padding: 0 30px;
    margin: 20px 0;
    width: 70%;
    height: 50px;
  }
}

main .account .account-container .account-login .account-form button, main .account .account-container .account-signup .account-form button {
  background: #fff;
  padding: 5px 10px;
  height: 35px;
  color: #0533ed;
  border: solid 2px #fff;
  border-radius: 30px;
  margin-top: 15px;
  transition-duration: 0.6s;
  box-shadow: 0 3px 10px 0.1px rgba(0, 0, 0, 0.42);
}
main .account .account-container .account-login .account-form button:hover, main .account .account-container .account-signup .account-form button:hover {
  letter-spacing: 0.2em;
  transition-duration: 0.6s;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-login .account-form button, main .account .account-container .account-signup .account-form button {
    height: 50px;
    font-size: 24px;
    margin: 50px 25% 0 25%;
    width: 50%;
  }
}

.alq-search {
  width: 100vw;
  display: flex;
  justify-content: center;
  margin: 20px 0;
  position: sticky;
  top: 10px;
  z-index: 100;
}
.alq-search .alq-search-bar {
  display: flex;
  justify-content: center;
  padding: 15px 25px;
  border-radius: 30px;
  align-content: center;
  width: auto;
  background: #0533ed;
  box-shadow: 0px 7px 11px 5px rgba(0, 0, 0, 0.12);
}
@media only screen and (max-width: 768px) {
  .alq-search .alq-search-bar {
    width: 100%;
    padding: 20px 15px;
    margin: 0 10px;
  }
}
.alq-search div {
  width: 800px;
  display: flex;
  justify-content: space-between;
}
.alq-search div select {
  height: 35px;
  width: 200px;
  border-radius: 6px;
  border: none;
  text-align: center;
}
@media only screen and (max-width: 768px) {
  .alq-search div select {
    width: 100%;
    margin-bottom: 8px;
    font-size: 20px;
    height: 50px;
  }
}
@media only screen and (max-width: 768px) {
  .alq-search div {
    flex-direction: column;
    width: 100%;
  }
}
@media only screen and (max-width: 768px) {
  .alq-search {
    position: inherit;
  }
}

.alq-main {
  margin: 0 5vw;
}
.alq-main .alq-container {
  display: flex;
  background: #24c3c8;
  margin-bottom: 10px;
  border-radius: 20px;
}
.alq-main .alq-container .alq-container-img {
  width: 40%;
  height: auto;
  margin: 10px;
  overflow: hidden;
}
.alq-main .alq-container .alq-container-img img {
  width: 100%;
  height: 400px;
  border-radius: 20px;
  object-fit: cover;
  border-radius: 20px;
  border: solid 6px #fff;
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-img img {
    border: none;
  }
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-img {
    width: auto;
  }
}
.alq-main .alq-container .alq-container-desc {
  width: 60%;
  padding: 15px 10px 15px 25px;
}
.alq-main .alq-container .alq-container-desc .alq-container-title {
  font-size: 22px;
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-desc .alq-container-title {
    font-size: 28px;
  }
}
.alq-main .alq-container .alq-container-desc .alq-container-sku {
  font-size: 13px;
  padding-bottom: 15px;
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-desc .alq-container-sku {
    font-size: 20px;
  }
}
.alq-main .alq-container .alq-container-desc .accordion-item {
  background: rgba(255, 255, 255, 0.4);
  border: solid 1px #000;
  font-size: 22px;
}
.alq-main .alq-container .alq-container-desc .accordion-item .accordion-text {
  font-size: 14px;
}
.alq-main .alq-container .alq-container-desc .alq-container-maps {
  margin-top: 10px;
  border-radius: 10px;
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-desc .alq-container-maps {
    margin-bottom: 14px;
    width: 70%;
  }
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-desc {
    width: 100%;
    padding: 0 15px;
    box-sizing: border-box;
    text-align: center;
  }
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container {
    flex-direction: column;
    border-radius: 10px;
    padding: 10px;
    margin-bottom: 30px;
    box-sizing: border-box;
    overflow: hidden;
  }
}
@media only screen and (max-width: 768px) {
  .alq-main {
    margin: 0;
    box-sizing: border-box;
  }
}

main .contact-sec1 {
  padding: 70px 0;
}
@media only screen and (max-width: 768px) {
  main .contact-sec1 {
    padding: 70px 0 40px 0;
  }
}
main .contact-sec1 h1 {
  text-align: center;
  padding-bottom: 50px;
}
main .contact-sec1 .contact-sec1-items {
  display: flex;
  justify-content: space-between;
  padding: 20px 15%;
  text-align: center;
}
@media only screen and (max-width: 768px) {
  main .contact-sec1 .contact-sec1-items {
    flex-direction: column;
    padding: 0;
  }
}
@media only screen and (max-width: 768px) {
  main .contact-sec1 .contact-sec1-items .contact-sec1-items-item {
    margin-bottom: 60px;
  }
}
main .contact-sec1 .contact-sec1-items .contact-sec1-items-item img {
  width: 100px;
  margin-bottom: 15px;
  transition-duration: 0.7s;
}
main .contact-sec1 .contact-sec1-items .contact-sec1-items-item img:hover {
  width: 107px;
  transition-duration: 0.7s;
}
@media only screen and (max-width: 768px) {
  main .contact-sec1 .contact-sec1-items .contact-sec1-items-item img {
    width: 70px;
    margin: 0;
  }
}
main .contact-sec2 {
  display: flex;
  justify-content: center;
  background-image: url(.././src/images/alquiler-1.jpg);
  background-position: center;
  background-size: cover;
  color: #fff;
}
@media only screen and (max-width: 768px) {
  main .contact-sec2 {
    flex-direction: column;
    width: 100vw;
    padding: 0;
    overflow: hidden;
  }
}
main .contact-sec2 .contact-sec2-left {
  width: 50%;
  background-image: linear-gradient(rgba(5, 51, 237, 0.4), #0533ed);
  padding: 45px 0 30px 7%;
}
@media only screen and (max-width: 768px) {
  main .contact-sec2 .contact-sec2-left {
    width: 100%;
    padding: 45px 18px;
    box-sizing: border-box;
    text-align: center;
  }
}
main .contact-sec2 .contact-sec2-left p {
  font-size: 14px;
  text-align: justify;
  padding-right: 55px;
  padding-top: 20px;
}
@media only screen and (max-width: 768px) {
  main .contact-sec2 .contact-sec2-left p {
    padding: 20px 0 0 0;
    font-size: 20px;
  }
}
@media only screen and (max-width: 768px) {
  main .contact-sec2 .contact-sec2-left h2 {
    font-size: 28px;
  }
}
main .contact-sec2 .contact-sec2-left ul {
  margin: 25px 0 0 40px;
  font-size: 14px;
}
@media only screen and (max-width: 768px) {
  main .contact-sec2 .contact-sec2-left ul {
    margin: 20px 2px 0 25px;
    text-align: left;
  }
}
main .contact-sec2 .contact-sec2-left ul li {
  margin-bottom: 10px;
}
main .contact-sec2 .contact-sec2-rigth {
  width: 50%;
  padding: 45px 0 30px 7%;
  background: rgba(5, 51, 237, 0.83);
}
@media only screen and (max-width: 768px) {
  main .contact-sec2 .contact-sec2-rigth {
    width: 100%;
    padding: 45px 18px;
    text-align: center;
    box-sizing: border-box;
  }
}
main .contact-sec2 .contact-sec2-rigth .contact-form {
  background: orange;
  width: 80%;
  height: 300px;
  border-radius: 20px;
}
@media only screen and (max-width: 768px) {
  main .contact-sec2 .contact-sec2-rigth .contact-form {
    width: 100%;
  }
}

* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
main .us-banner {
  background-image: url(../src/images/hostel.jpg);
  background-size: cover;
  background-position: center;
  text-align: center;
}
@media only screen and (max-width: 768px) {
  main .us-banner {
    min-height: auto;
  }
}
main .us-banner .us-banner-backg {
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.4);
  display: flex;
  flex-direction: column;
  justify-content: center;
}
@media only screen and (max-width: 768px) {
  main .us-banner .us-banner-backg {
    height: auto;
  }
}
main .us-banner .us-banner-backg h1 {
  color: #fff;
  margin-top: 100px;
}
@media only screen and (max-width: 768px) {
  main .us-banner .us-banner-backg h1 {
    margin-top: 60px;
  }
}
main .us-banner .us-banner-backg p {
  color: #fff;
  margin-top: 20px;
  padding: 0 15%;
  margin-bottom: 100px;
}
@media only screen and (max-width: 768px) {
  main .us-banner .us-banner-backg p {
    font-size: 24px;
    padding: 0 20px;
    margin-bottom: 60px;
  }
}
main .us-expla {
  margin: 40px 10%;
}
main .us-expla .us-expla-text {
  text-align: justify;
}
@media only screen and (max-width: 768px) {
  main .us-expla .us-expla-text {
    width: 100%;
    font-size: 24px;
    margin-bottom: 20px;
    order: 1;
    /* Aplicamos reordenamiento de columnas para que siempre sea texto + imagen */
  }
}
main .us-expla .us-expla-img {
  object-fit: fill;
  display: flex;
  justify-content: center;
  height: 300px;
}
@media only screen and (max-width: 768px) {
  main .us-expla .us-expla-img {
    width: 100%;
    order: 2;
    /* Aplicamos reordenamiento de columnas para que siempre sea texto + imagen */
  }
}
main .us-expla .us-expla-img img {
  width: 100%;
  border-radius: 5px;
}
main .us-counter {
  margin: 65px 22%;
  display: flex;
  justify-content: space-between;
}
@media only screen and (max-width: 768px) {
  main .us-counter {
    flex-direction: column;
    margin: 0;
    align-items: center;
  }
}
main .us-counter .us-counter-item {
  width: 33%;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
  font-weight: 700;
}
@media only screen and (max-width: 768px) {
  main .us-counter .us-counter-item {
    font-size: 24px;
    margin-top: 40px;
  }
}
main .us-counter .us-counter-item img {
  width: 100px;
  margin: 13px 0;
}
@media only screen and (max-width: 768px) {
  main .us-counter .us-counter-item img {
    margin: 5px 0;
    width: 70px;
  }
}

* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
main .account .account-container .account-login .account-form, main .account .account-container .account-signup .account-form {
  margin-top: 20px;
  margin-left: 10px;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-login .account-form, main .account .account-container .account-signup .account-form {
    margin: 20px 0 0 0;
    display: flex;
    flex-direction: column;
  }
}
main .account .account-container .account-login .account-form p, main .account .account-container .account-signup .account-form p {
  font-size: 15px;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-login .account-form p, main .account .account-container .account-signup .account-form p {
    font-size: 24px;
    padding: 0 10px;
  }
}
main .account .account-container .account-login .account-form input, main .account .account-container .account-signup .account-form input {
  width: 80%;
  height: 30px;
  margin-bottom: 10px;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-login .account-form input, main .account .account-container .account-signup .account-form input {
    height: 40px;
    margin: 0 10%;
  }
}
main .account {
  background-image: url(.././src/images/hostel.jpg);
  background-size: cover;
  height: calc(100vh - 80px);
}
@media only screen and (max-width: 768px) {
  main .account {
    height: auto;
  }
}
main .account .account-container {
  display: flex;
  justify-content: center;
  padding: 50px 30px;
}
@media only screen and (max-width: 768px) {
  main .account .account-container {
    margin: 0;
    padding: 5%;
    text-align: center;
  }
}
main .account .account-container .account-signup {
  background-color: #0533ed;
  width: 50%;
  padding: 20px;
  border-radius: 15px 0 0 15px;
  color: #fff;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-signup {
    width: 100%;
    padding: 30px 0;
    border-radius: 15px 15px 0 0;
  }
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-signup p {
    font-size: 24px;
  }
}
main .account .account-container .account-login {
  background-color: #2cd4d9;
  width: 50%;
  padding: 20px;
  border-radius: 0 15px 15px 0;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-login {
    width: 100%;
    padding: 30px 0;
    border-radius: 0 0 15px 15px;
  }
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-login p {
    font-size: 24px;
  }
}
* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
#header-index .header-container .welcome-container .welcome-container-title button, #header-index .header-container .search-bar .elements button, .alq-search div button {
  background: #2cd4d9;
  min-width: 120px;
  height: 35px;
  color: #0533ed;
  border: solid 2px #fff;
  border-radius: 30px;
  transition-duration: 0.6s;
}
#header-index .header-container .welcome-container .welcome-container-title button:hover, #header-index .header-container .search-bar .elements button:hover, .alq-search div button:hover {
  background: #fff;
  border: solid 3px #2cd4d9;
  box-shadow: inset 0 0 10px 0.3px #0533ed;
  transition-duration: 0.6s;
}
@media only screen and (max-width: 768px) {
  #header-index .header-container .welcome-container .welcome-container-title button, #header-index .header-container .search-bar .elements button, .alq-search div button {
    font-size: 24px;
    height: 45px;
    min-width: 240px;
  }
}

.alq-main .alq-container .alq-container-desc .alq-container-btn {
  background: #0533ed;
  width: 180px;
  height: 35px;
  color: #fff;
  border: solid 2px #fff;
  margin: 15px 25px 15px 0;
  border-radius: 30px;
}
.alq-main .alq-container .alq-container-desc .alq-container-btn:hover {
  background: #fff;
  color: #0533ed;
  border: solid 3px #0533ed;
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-desc .alq-container-btn {
    font-size: 24px;
    padding: 0 30px;
    margin: 20px 0;
    width: 70%;
    height: 50px;
  }
}

main .account .account-container .account-signup .account-form button, main .account .account-container .account-login .account-form button {
  background: #fff;
  padding: 5px 10px;
  height: 35px;
  color: #0533ed;
  border: solid 2px #fff;
  border-radius: 30px;
  margin-top: 15px;
  transition-duration: 0.6s;
  box-shadow: 0 3px 10px 0.1px rgba(0, 0, 0, 0.42);
}
main .account .account-container .account-signup .account-form button:hover, main .account .account-container .account-login .account-form button:hover {
  letter-spacing: 0.2em;
  transition-duration: 0.6s;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-signup .account-form button, main .account .account-container .account-login .account-form button {
    height: 50px;
    font-size: 24px;
    margin: 50px 25% 0 25%;
    width: 50%;
  }
}

.activities {
  margin: auto;
  display: table;
  padding-bottom: 18px;
}
.activities h2 {
  text-align: center;
  margin: 47px 0;
}
.activities .activities-list {
  width: 80vw;
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  grid-template-rows: repeat(3, 250px);
  gap: 9px 9px;
  grid-template-areas: "img2 img2 img1" "img3 img4 img4" "img5 img5 img6";
}
@media only screen and (max-width: 768px) {
  .activities .activities-list {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 100vw;
    padding: 0 20px;
    box-sizing: border-box;
  }
}
.activities .activities-list .image-container {
  overflow: hidden;
  box-shadow: 2px 2px 2px 1px rgba(0, 0, 0, 0.2);
  background: #0533ed;
}
@media only screen and (max-width: 768px) {
  .activities .activities-list .image-container {
    margin-bottom: 15px;
    height: 200px;
    width: 95%;
  }
}
.activities .activities-list .image-container img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  transition: ease-in 0.6s;
}
.activities .activities-list .image-container img:hover {
  transform: scale(1.05);
  transition: ease-in 0.6s;
  opacity: 0.6;
}

.img-x1 {
  grid-area: img1;
}

.img-x2 {
  grid-area: img2;
}

.img-x3 {
  grid-area: img3;
}

.img-x4 {
  grid-area: img4;
}

.img-x5 {
  grid-area: img5;
}

.img-x6 {
  grid-area: img6;
}

* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
* {
  margin: 0;
  padding: 0;
  font-family: "Nunito", sans-serif;
  letter-spacing: 0.08rem;
}

h1 {
  font-size: 40px;
}

h2 {
  font-size: 25px;
}

@media only screen and (max-width: 768px) {
  /* Definimos tamaño de texto para los elementos h1, h2 y h3 */
  h1 {
    font-size: 28px;
  }

  h2 {
    font-size: 28px;
  }

  h3 {
    font-size: 20px;
  }
}
#header-index .header-container .welcome-container .welcome-container-title button, #header-index .header-container .search-bar .elements button, .alq-search div button {
  background: #2cd4d9;
  min-width: 120px;
  height: 35px;
  color: #0533ed;
  border: solid 2px #fff;
  border-radius: 30px;
  transition-duration: 0.6s;
}
#header-index .header-container .welcome-container .welcome-container-title button:hover, #header-index .header-container .search-bar .elements button:hover, .alq-search div button:hover {
  background: #fff;
  border: solid 3px #2cd4d9;
  box-shadow: inset 0 0 10px 0.3px #0533ed;
  transition-duration: 0.6s;
}
@media only screen and (max-width: 768px) {
  #header-index .header-container .welcome-container .welcome-container-title button, #header-index .header-container .search-bar .elements button, .alq-search div button {
    font-size: 24px;
    height: 45px;
    min-width: 240px;
  }
}

.alq-main .alq-container .alq-container-desc .alq-container-btn {
  background: #0533ed;
  width: 180px;
  height: 35px;
  color: #fff;
  border: solid 2px #fff;
  margin: 15px 25px 15px 0;
  border-radius: 30px;
}
.alq-main .alq-container .alq-container-desc .alq-container-btn:hover {
  background: #fff;
  color: #0533ed;
  border: solid 3px #0533ed;
}
@media only screen and (max-width: 768px) {
  .alq-main .alq-container .alq-container-desc .alq-container-btn {
    font-size: 24px;
    padding: 0 30px;
    margin: 20px 0;
    width: 70%;
    height: 50px;
  }
}

main .account .account-container .account-signup .account-form button, main .account .account-container .account-login .account-form button {
  background: #fff;
  padding: 5px 10px;
  height: 35px;
  color: #0533ed;
  border: solid 2px #fff;
  border-radius: 30px;
  margin-top: 15px;
  transition-duration: 0.6s;
  box-shadow: 0 3px 10px 0.1px rgba(0, 0, 0, 0.42);
}
main .account .account-container .account-signup .account-form button:hover, main .account .account-container .account-login .account-form button:hover {
  letter-spacing: 0.2em;
  transition-duration: 0.6s;
}
@media only screen and (max-width: 768px) {
  main .account .account-container .account-signup .account-form button, main .account .account-container .account-login .account-form button {
    height: 50px;
    font-size: 24px;
    margin: 50px 25% 0 25%;
    width: 50%;
  }
}

.why-us-container {
  background: #25c7cc;
  padding: 35px 0;
  text-align: center;
  color: #fff;
}
.why-us-container .why-us-items {
  display: flex;
  justify-content: space-around;
  margin-top: 30px;
}
@media only screen and (max-width: 768px) {
  .why-us-container .why-us-items {
    flex-direction: column;
  }
}
.why-us-container .why-us-items .why-us-items-item {
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
  align-items: center;
}
@media only screen and (max-width: 768px) {
  .why-us-container .why-us-items .why-us-items-item {
    margin-bottom: 45px;
  }
}
@media only screen and (max-width: 768px) {
  .why-us-container .why-us-items .why-us-items-item p {
    font-size: 24px;
  }
}
.why-us-container .why-us-items .why-us-items-item img {
  width: 70px;
  padding-bottom: 10px;
}

/*# sourceMappingURL=style.cs.map */
