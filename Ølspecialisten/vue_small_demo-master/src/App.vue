<template>
<div>
  <header>
    <div id="logo">
      <a href="/"><img src="img/logo_bottlecap.png" width="70" height="70" alt="logo"></a>
    </div>
    <nav>
      <ul>
        <li><a href="/danske">DANSK SPECIALØL</a>
          <ul>
            <li>
              <a href="/danske">Alle Danske Øl</a>
              <a href="/#hex_top">Top 3 Danske Øl</a>
            </li>
          </ul>
        </li>
        <li><a href="/norske">NORSK SPECIALØL</a>
          <ul>
            <li>
              <a href="/norske">Alle Norske Øl</a>
              <a href="/#hex_middle">Top 3 Norske Øl</a>
            </li>
          </ul>
        </li>
        <li><a href="/svenske">SVENSK SPECIALØL</a>
          <ul>
            <li>
              <a href="/svenske">Alle Svenske Øl</a>
              <a href="/#hex_bottom">Top 3 Svenske Øl</a>
            </li>
          </ul>
        </li>
        <a href="/create">Create</a>
        <a href="/admin">Read</a>
        <a href="/shoes">Update</a>
        <a href="/albums">Delete</a>
      </ul>

    </nav>
    <div id="shopping_cart">
      <a href="basket.html"><i class="fas fa-shopping-cart"></i></a>
    </div>
  </header>

  <div id="app">

    <router-view/>

    <footer>
      <div id="footer_container">
        <div id="footer_top">
          <h4>ØLSPECIALISTEN</h4>
          <p>ØlSpecialisten er Nordens top udbyder af bajsebamser fra de nordiske lande og vi stræber efter god kvalitet og formidabel service</p>
        </div>
        <div id="footer_bottom">
          <div class="footer_box">
            <div id="footer_logo">
              <a href="index.html"><img src="img/logo_bottlecap.png" width="100" height="100" alt="logo"></a>
            </div>
          </div>
          <div class="footer_box">
            <h5>Kontakt</h5>
            <p>Ådalshaven 129</p>
            <p>6710 Esbjerg V</p>
            <p>ØlSpecialisten@gmail.com</p>
          </div>
          <div class="footer_box">
            <h5>Åbningstider</h5>
            <p>Man-Fre 09:00-16:30</p>
            <p>Lør-Søn 09:00-13:30</p>
            <p>Helligdage 09:00-11:00</p>
          </div>
          <div class="footer_box">
            <h5>Betalingsmetoder</h5>
            <p>Visa/Dankort</p>
            <p>MobilePay</p>
            <p>Paypal</p>
          </div>
          <div class="footer_box">
            <div id="footer_social">
              <a href="#"><i class="fab fa-instagram"></i></a>
              <a href="#"><i class="fab fa-twitter"></i></a>
              <a href="#"> <i class="fab fa-facebook-f"></i></a>
            </div>
          </div>
        </div>
        <div id="footer_text">
          <p>2019 ØlSpecialisten, all rights reserved</p>
          <p>Copyright by group 4</p>
          <p><a href="#">Admin page</a></p>
        </div>
      </div>
    </footer>
  </div>
  </div>
</template>

<script>
export default {
  name: 'App',
  components: {},
  data: () => ({
    //
  }),
};
</script>

<style>
  #app {
    font-family: 'Avenir', Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
    margin-top: 60px;
  }

  body{
    margin: 0;
    padding: 0;
  }

  /* HEADER START */

  header{
    background-color: black;
    height: 80px;
    display: flex;
    justify-content: center;
    align-items: center;
    position: relative;
    z-index: 99999;
    font-family: 'Karma', serif;
  }

  i{
    color: #ededed;
  }

  i.fas.fa-shopping-cart{
    font-size: 26px;
  }

  i.fas.fa-shopping-cart:hover{
    color: white;
    transition: 500ms ease;
  }

  #logo{
    width: 180px;
    display: flex;
    box-sizing: border-box;
    flex-grow: 1;
    justify-content: center;
    align-items: center;
  }

  nav{
    display: flex;
    align-items: center;
    justify-content: space-evenly;
    flex-grow: 9;
    box-sizing: border-box;
  }

  nav ul{
    display: flex;
    list-style: none;
    padding: 0;
    margin: 0;
  }

  nav a{
    color: #ededed;
    font-size: 20px;
    padding: 0 8px;
    text-decoration: none;
    margin: 0 20px;
  }

  nav a:hover{
    color: rgb(233, 212, 187);
    transition: 500ms ease;
  }

  nav ul li:hover{
    background-color: black;
  }

  nav ul li{
    transition: all 500ms;
  }

  nav ul li ul li{
    background-color: black;
    padding: 8px 0 0 0;
  }

  nav ul li ul a:hover{
    color: 333333;
    transition: 500ms;
    background-color: rgba(102, 102, 105, 0.322);
  }

  nav ul li ul{
    display: none;
    position: absolute;
  }

  nav ul li:hover ul{
    display: block;
    opacity: 1;
  }

  nav ul li ul li a{
    display: block;
    text-align: left;
    color: white;
    width: 120px;
    padding: 7px 40px 10px 7px;
    font-size: 15px;
  }

  a:visited{
    color: #ededed;
  }

  #shopping_cart{
    display: flex;
    width: 180px;
    flex-grow: 2;
    align-items: center;
    justify-content: space-evenly;
    box-sizing: border-box;
    padding: 0 80px;
  }

  /*HEADER END*/
  /*INDEX MAIN START*/
  /*MAIN TOP START*/

  #main_container{
    width: 100%;
    height: 2500px;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    background-repeat: no-repeat;
    background-size: cover;
    margin-top: -80px;
    padding: 150px 0 0 0;
    font-family: 'Karma', serif;
    box-sizing: border-box;
  }

  #main_top{
    width: 100%;
    height: 450px;
    box-sizing: border-box;
  }

  /*INDEX MAIN TOP END*/
  /*INDEX MAIN BOTTOM START*/

  #main_bottom{
    width: 100%;
    height: auto;
    display: flex;
    justify-content: center;
    flex-flow: column;
    margin: 0;
    padding: 0;
  }

  #hex_top, #hex_middle, #hex_bottom{
    height: 500px;
    width: 100%;
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
    box-sizing: border-box;
    margin: 30px 0 30px 0;
  }

  #hex_top_text{
    justify-content: center;
    height: 100px;
    width: 100%;
    text-align: center;
    box-sizing: border-box;
    margin-top: 50px;
  }

  .products{
    background-color: rgba(238, 225, 210, 0.822);
    height: 400px;
    width: 200px;
    margin: 0 60px;
    box-sizing: border-box;
    box-shadow: 0px 1px 1px black;
  }

  #product_link {
    margin-top: 20px;
  }

  #product_link a{
    text-decoration: none;
    color: rgb(233, 212, 187);
    margin: 0 0 0 38px;
    border: 2px solid black;
    border-radius: 4px;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    text-transform: uppercase;
    padding: 0 5px 0 5px;
  }

  #product_link a:hover{
    transition: 200ms;
    box-shadow: 0px 2px 2px black;
  }

  h3{
    text-align: center;
    margin-bottom: 10px;
    margin-top: -5px;
  }

  #hex_middle_text{
    justify-content: center;
    height: 100px;
    width: 100%;
    text-align: center;
    box-sizing: border-box;
    margin-top: 50px;
  }

  #hex_bottom_text{
    justify-content: center;
    height: 100px;
    width: 100%;
    text-align: center;
    box-sizing: border-box;
    margin-top: 50px;
  }

  #hex_middle_text, #hex_top_text, #hex_bottom_text{
    color: white;
    text-shadow: 1px 1px 1px black;
  }

  h1{
    color: white;
  }

  .products p{
    display: flex;
    margin: 0 0 0 5px;
    padding: 0;
  }

  /*INDEX MAIN BOTTOM END*/
  /*INDEX MAIN END*/
  /*DESCRIPTION MAIN START*/

  #main_container_2{
    width: 100%;
    height: 1000px;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    background-repeat: no-repeat;
    background-size: cover;
    margin-top: -80px;
    font-family: 'Karma', serif;
    box-sizing: border-box;
    display: flex;
    justify-content: center;
    align-items: center;
  }

  #product_container{
    width: 1200px;
    height: 600px;
    background-color: rgba(238, 225, 210, 0.822);
    display: flex;
    box-shadow: 0px 1px 1px black;
    box-sizing: border-box;
  }

  #product_img{
    height: 600px;
    width: 50%;
  }

  #product_text{
    width: 50%;
    height: 600px;
    box-sizing: border-box;
    display: flex;
    flex-wrap: wrap;
  }

  #product_title{
    height: 150px;
    width: 100%;
    box-sizing: border-box;
    text-transform: uppercase;
    display: flex;
    justify-content: center;
    align-items: center;
  }

  #product_title h3{
    font-size: 40px;
  }

  #product_description{
    height: 300px;
    width: 100%;
    box-sizing: border-box;
    display: flex;
    justify-content: space-between;
    flex-direction: column;
    padding-left: 15px;
    font-weight: bold;
  }

  #price_container{
    display: flex;
    justify-content: space-around;
    height: 150px;
    width: 100%;
    box-sizing: border-box;
    align-items: flex-end;

  }

  #price_button, #price_container h3{
    margin: 0 0 40px 0;
  }

  #price_container h3{
    font-size: 30px;
    text-transform: uppercase;
  }

  #price_button a{
    text-decoration: none;
    color: rgb(233, 212, 187);
    border: 2px solid black;
    border-radius: 4px;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    text-transform: uppercase;
    font-size: 26px;
    padding: 0 5px 0 5px;
  }

  #price_button a:hover{
    transition: 200ms;
    box-shadow: 0px 2px 2px black;
  }

  #price_button a:visited{
    color: rgb(233, 212, 187);
  }
  /*DESCRIPTION MAIN END/*
  /*BASKET MAIN START*/

  #main_container_3{
    width: 100%;
    height: auto;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    background-repeat: no-repeat;
    background-size: cover;
    margin-top: -80px;
    font-family: 'Karma', serif;
    padding-top: 80px;
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  #basket_title{
    width: 100%;
    height: 100px;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-top: 50px;
    letter-spacing: 4px;
  }

  #basket_title h2{
    font-size: 34px;
    color: white;
    text-shadow: 1px 1px 1px black;
    margin: 0 10px 0 0;
  }

  #basket_title i{
    color: white;
    font-size: 30px;
    text-shadow: 1px 1px 1px black;
  }

  #basket_products{
    width: 800px;
    height: auto;
    background-color: rgba(238, 225, 210, 0.822);
    display: flex;
    flex-wrap: wrap;
    box-shadow: 0px 1px 1px black;
  }

  .basket_items{
    width: 100%;
    height: 200px;
    box-sizing: border-box;
    display: flex;
    flex-wrap: wrap;
    border-bottom: 1px solid black;
  }

  .items_img{
    height: 200px;
    width: 200px;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-right: 50px;
  }

  #items_description{
    height: 200px;
    width: 275px;
    box-sizing: border-box;
  }

  #items_description h3{
    margin-top: 20px;
    font-size: 25px;
    display: flex;
  }

  #items_price{
    height: 200px;
    width: 275px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }

  #items_price h3{
    font-size: 25px;
    margin-bottom: -5px;
  }

  #basket_total_price{
    width: 100%;
    height: 100px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }

  #basket_total_price h2{
    font-size: 34px;
    color: white;
    text-shadow: 1px 1px 1px black;
    margin-bottom: -2px;
  }

  #basket_total_price a{
    text-decoration: none;
    color: rgb(233, 212, 187);
    border: 2px solid black;
    border-radius: 4px;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    text-transform: uppercase;
    font-size: 26px;
    padding: 0 5px 0 5px;
  }

  #basket_total_price a:hover{
    transition: 200ms;
    box-shadow: 0px 2px 2px black;
  }

  #basket_total_price a:visited{
    color: rgb(233, 212, 187);
  }

  /*BASKET MAIN ENDS*/
  /*ORDER MAIN START*/

  #main_container_4{
    width: 100%;
    height: 1200px;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    background-repeat: no-repeat;
    background-size: cover;
    margin-top: -80px;
    font-family: 'Karma', serif;
    padding-top: 80px;
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  #order_title{
    width: 100%;
    height: 100px;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-top: 50px;
    letter-spacing: 4px;
  }

  #order_title h2{
    font-size: 34px;
    color: white;
    text-shadow: 1px 1px 1px black;
    margin: 0 10px 0 0;
  }

  #order_container{
    width: 800px;
    height: 800px;
    background-color: rgba(255, 255, 255, 0.774);
    box-shadow: 0px 1px 1px black;
    display: flex;
  }

  #order_info{
    width: 50%;
    height: 100%;
    margin-top: 18px;
  }

  #order_container form{
    font-size: 18px;
    font-family: 'Karma', serif;
  }

  input[type=submit] {
    color: rgb(233, 212, 187);
    border: 2px solid black;
    border-radius: 4px;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    text-transform: uppercase;
    font-size: 26px;
    padding: 0 5px 0 5px;
    margin-left: 35%;
  }

  input[type=submit]:hover{
    transition: 200ms;
    box-shadow: 0px 2px 2px black;
  }

  #order_overview{
    width: 50%;
    height: 100%;
  }

  #order_overview p{
    display: flex;
    justify-content: center;
    align-items: center;
    text-transform: uppercase;
    font-weight: bold;
    font-size: 24px;
  }

  /*ORDER MAIN ENDS*/
  /*ALL MAIN START*/

  #main_container_5{
    width: 100%;
    height: auto;
    background-image: url(https://wallpaperaccess.com/full/717263.png);
    background-repeat: no-repeat;
    background-size: cover;
    margin-top: -80px;
    font-family: 'Karma', serif;
    padding-top: 80px;
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  #all_title{
    width: 100%;
    height: 100px;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-top: 50px;
    letter-spacing: 4px;
  }

  #all_title h2{
    font-size: 34px;
    color: white;
    text-shadow: 1px 1px 1px black;
    margin: 0 10px 0 0;
    text-transform: uppercase;
  }

  #all_container{
    height: auto;
    width: 80%;
    display: flex;
    flex-wrap: wrap;
  }

  .all_beers{
    background-color: rgba(238, 225, 210, 0.822);
    height: 400px;
    width: 200px;
    margin: 0 20px 40px 20px;
    box-sizing: border-box;
    box-shadow: 0px 1px 1px black;
  }

  .all_beers p{
    display: flex;
    margin: 0 0 0 5px;
    padding: 0;
  }

  /*ALL MAIN END*/
  /*FOOTER START*/
  footer{
    height: 300px;
    background-color: black;
    display: flex;
    justify-content: center;
    color: white;
    padding: 30px 0 0 0;
    z-index: 9999;
    position: relative;
    font-family: 'Karma', serif;
  }

  #footer_container{
    width: 90%;
    display: flex;
    justify-content: center;
    flex-direction: column;
  }

  #footer_top p, #footer_top h4{
    display: flex;
    margin: 0;
    justify-content: center;
  }

  #footer_top h4{
    font-size: 22px;
    letter-spacing: 4px;
    color: rgb(233, 212, 187);
    text-shadow: 1px 1px 0 black;
    border-top: 1px solid white;
  }

  #footer_bottom{
    margin: 40px 0 0 0;
    display: flex;
  }

  .footer_box{
    border: 1px solid white;
    padding: 20px;
    flex: 1;
    box-sizing: border-box;
  }

  .footer_box:not(:last-child){
    border-right: none;
  }

  footer p, footer h5{
    margin: 0;
    padding: 0;
  }

  footer p{
    margin: 5px 0 5px 0;
  }

  footer h5{
    margin: 0 0 10px 0;
    color: rgb(233, 212, 187);
    text-shadow: 1px 1px 0 black;
    font-size: 18px;
  }

  .footer_box a{
    text-decoration: none;
  }

  #footer_social{
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100%;
  }

  #footer_social a{
    width: 40px;
    height: 40px;
    margin: 0 0 0 5px;
    box-sizing: border-box;
    padding: 8px 0 0 12px;
    border: 1px solid white;
    border-radius: 20px;
  }

  #footer_logo{
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100%;
  }

  #footer_logo i{
    font-size: 40px;
  }

  #footer_text{
    display: flex;
    font-size: 9px;
    margin: 15px 0 0 0;
  }

  #footer_text p{
    flex: 1;
  }

  #footer_text p:nth-child(2){
    text-align: center;
  }

  #footer_text p:nth-child(3){
    text-align: right;
  }

  #footer_text a{
    text-decoration: none;
    color: white;
  }

  a:visited{
    color: white;
  }

  .responsive {
    width: 100%;
    height: auto;
  }

  /*FOOTER END*/



</style>
