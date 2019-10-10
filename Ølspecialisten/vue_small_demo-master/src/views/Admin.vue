<template>
  <div>
    <h1>Admin View</h1>
    <ul>
      <li v-for="product in products"
          v-bind:key="product.id">{{product.id}} | {{product.navn}} | {{product.pris}}Dkk | {{product.nation}} | {{product.lager}}stks | {{product.alkohol}}% | {{product.kapacitet}}cl | {{product.typeOfBeer}} | </li>
    </ul>

  </div>
</template>
¨
<script>
  import axios from 'axios';
  export default {
    mounted() {
      this.fetchProducts()
    },
    data: ()  => ({
      products: [{productId: 1, description: 'Helo'},{productId: 2, description: 'Bøf'}]
    }),
    methods: {
      fetchProducts() {

        axios.get('http://beerspecialist.azurewebsites.net/api/beer')
                .then((data) => {
                  this.products = data.data;

                });
      }
    }
  };
</script>