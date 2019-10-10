<template>
    <main>
        <div id="main_container_2">
            <div id="product_container">
                <li v-for="product in productsdk"
                    v-bind:key="product.id">
                    <div id="product_img">
                    <img :src="product.image64" alt="placeholder image" class="responsive">
                </div>
                </li>
                <div id="product_text">
                    <div id="product_title">
                        <li v-for="product in productsdk"
                            v-bind:key="product.id">
                        <h3>{{product.navn}}</h3>
                        </li>
                    </div>
                    <div id="product_description">
                <li v-for="product in productsdk"
                    v-bind:key="product.id">
                        <p>{{product.alkohol}}%</p>
                        <p>{{product.kapacitet}}cl</p>
                        <p>{{product.typeOfBeer}}</p>
                        <p>{{product.beskrivelseLang}}</p>
                        <p>{{product.nation}}</p>
                </li>
                    </div>

                    <div id="price_container">
                        <li v-for="product in productsdk"
                            v-bind:key="product.id">
                        <h3>{{product.pris}}dkk</h3>
                        </li>
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
            productsdk: {productId: 1, description: 'Helo'}
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
    .responsive {
        max-width: 900px;
        max-height: 600px;
    }
</style>