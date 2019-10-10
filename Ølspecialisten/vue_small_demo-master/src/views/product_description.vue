<template>
    <main>
        <div id="main_container_2">
            <div id="product_container">
                <div id="product_img">
                    <img :src="url" alt="placeholder image" class="responsive">
                </div>
                <div id="product_text">
                    <div id="product_title">
                        <h3>{{navn}}</h3>
                    </div>
                    <div id="product_description">
                        <p>alkohol: {{alkohol}}%</p>
                        <p>Indhold: {{indhold}}cl</p>
                        <p>{{type}} øl</p>
                        <p>{{beskrivelseLang}}</p>
                        <p>{{nation}} øl</p>
                    </div>
                    <div id="price_container">
                        <h3>{{pris}}dkk</h3>
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
        data()  {
            return {
                productsdk: {},
                incId: this.$route.params.id,
                alkohol: 0,
                navn: 'adwa',
                url: '',
                indhold: '',
                type: '',
                beskrivelseLang: '',
                nation: '',
                pris: '',

        };},
        methods: {
            fetchProducts() {

                axios.get('http://beerspecialist.azurewebsites.net/api/beer?id=' + this.$route.params.id)
                    .then((data) => {
                        this.productsdk = data.data[0];
                        this.alkohol = this.productsdk.alkohol;
                        this.url = this.productsdk.image64;
                        this.indhold = this.productsdk.kapacitet;
                        this.type = this.productsdk.typeOfBeer;
                        this.beskrivelseLang = this.productsdk.beskrivelseLang;
                        this.nation = this.productsdk.nation;
                        this.pris = this.productsdk.pris;
                        this.navn = this.productsdk.navn;

                    });
            }
        }
    };
</script>

<style scoped>
    .responsive {
        max-width: 600px;
        max-height: 600px;
    }
</style>