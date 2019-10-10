<template>
    <main>
        <div id="main_container_5">
            <div id="all_title">
                <h2>Alle Danske øl</h2>
            </div>
            <div id="all_container">
                <li v-for="product in productsdk"
                    v-bind:key="product.id">
                <div class="all_beers">


                    <a href="product_description.html"><img :src="product.image64" alt="placeholder image" class="responsive"></a>
                    <h3>{{product.navn}}</h3>
                    <p>{{product.alkohol}}</p>
                    <p>{{product.kapacitet}}</p>
                    <p>{{product.typeOfBeer}}</p>
                    <p>{{product.pris}}</p>
                    <div id="product_link">
                        <a href="#">Tilføj til kurv</a>
                    </div>

                </div>
                </li>
            </div>
        </div>
    </main>

</template>

<script>
    import axios from 'axios';
    export default {
        mounted() {
            this.fetchProducts()
        },
        data: ()  => ({
            productsdk: [{productId: 1, description: 'Helo'},{productId: 2, description: 'Bøf'}],
            productsno: [{productId: 1, description: 'Helo'},{productId: 2, description: 'Bøf'}],
            productsse: [{productId: 1, description: 'Helo'},{productId: 2, description: 'Bøf'}],
            /*incId: this.$route.params.id*/
        }),
        methods: {
            fetchProducts() {

                axios.get('http://beerspecialist.azurewebsites.net/api/beer?land=dansk')
                    .then((data) => {
                        this.productsdk = data.data;

                    });
            }
        }
    };
</script>

<style scoped>
    .responsive {
        max-width: 200px;
        max-height: 200px;
    }
</style>