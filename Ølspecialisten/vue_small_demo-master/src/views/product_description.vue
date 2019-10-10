<template>
    <main>
        <h3>title</h3>
        <div id="main_container_2">
            <div id="product_container">

                <div id="product_img">
                    <img src="product.image64" alt="placeholder image">
                </div>
                <div id="product_text">
                    <div id="product_title">
                        <h3>this.product.navn</h3>
                    </div>

                    <div id="product_description">
                        <li v-for="product in productsdk"
                            v-bind:key="product.id">

                        <p>{{product.id}}</p>
                        <p>{{product.titel}}</p>
                        <p>type</p>
                        <p>lang beskrivelse</p>
                        <p>Nationalitet</p>
                        </li>
                    </div>
                    <div id="price_container">
                        <h3>price</h3>
                        <div id="price_button"><a href="#">Tilføj til kurv</a></div>
                    </div>
                </div>

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

                axios.get('http://beerspecialist.azurewebsites.net/api/beer?id=1')
                    .then((data) => {
                        this.productsdk = data.data;

                    });
            }
        }
    };
</script>

<style scoped>

</style>