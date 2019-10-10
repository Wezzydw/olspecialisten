<template>
    <div>

        <main>
            <div id="main_container">

                <div id="main_top">
                    <img src="https://via.placeholder.com/1520x450" alt="placeholder image">
                </div>
                <div id="main_bottom">

                    <div id="hex_top"><!-- test v-for loop her -->
                        <div id="hex_top_text">
                            <h1>TOP 3 DANSKE SPECIALØL</h1>
                        </div>
                        <li v-for="product in productsdk"
                            v-bind:key="product.id">
                        <div class="products" @click="$router.push({name: 'desc', params:{id: product.id},})" >
                            <a><img :src="product.image64" alt="placeholder image" class="responsive" ></a>
                            <h3>{{product.navn}}</h3>
                            <p>Alko%: {{product.alkohol}}%</p>
                            <p>Kapacitet: {{product.kapacitet}}</p>
                            <p>Type: {{product.typeOfBeer}}</p>
                            <p>PRIS: {{product.pris}}dkk</p>
                            <p>{{product.beskrivelse}}dkk</p>
                            <div id="product_link">
                                <a href="#">Tilføj til kurv</a>
                            </div>
                        </div>
                        </li>

                    </div>

                    <div id="hex_middle">
                        <div id="hex_middle_text">
                            <h1>TOP 3 NORSKE SPECIALØL</h1>
                        </div>
                        <li v-for="product in productsno"
                            v-bind:key="product.id">
                            <div class="products" @click="$router.push({name: 'desc', params:{id: product.id},})" >
                                <a><img :src="product.image64" alt="placeholder image" class="responsive" ></a>
                                <h3>{{product.navn}}</h3>
                                <p>Alko%: {{product.alkohol}}%</p>
                                <p>Kapacitet: {{product.kapacitet}}</p>
                                <p>Type: {{product.typeOfBeer}}</p>
                                <p>PRIS: {{product.pris}}dkk</p>
                                <p>{{product.beskrivelse}}dkk</p>
                                <div id="product_link">
                                    <a href="#">Tilføj til kurv</a>
                                </div>
                            </div>
                        </li>

                    </div>

                    <div id="hex_bottom">
                        <div id="hex_bottom_text">
                            <h1>TOP 3 SVENSKE SPECIALØL</h1>
                        </div>
                        <li v-for="product in productsse"
                            v-bind:key="product.id">
                            <div class="products" @click="$router.push({name: 'desc', params:{id: product.id},})" >
                                <a><img :src="product.image64" alt="placeholder image" class="responsive" ></a>
                                <h3>{{product.navn}}</h3>
                                <p>Alko%: {{product.alkohol}}%</p>
                                <p>Kapacitet: {{product.kapacitet}}</p>
                                <p>Type: {{product.typeOfBeer}}</p>
                                <p>PRIS: {{product.pris}}dkk</p>
                                <p>{{product.beskrivelse}}dkk</p>
                                <div id="product_link">
                                    <a href="#">Tilføj til kurv</a>
                                </div>
                            </div>
                        </li>

                    </div>
                </div>
            </div>

        </main>

    </div>
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
            productsse: [{productId: 1, description: 'Helo'},{productId: 2, description: 'Bøf'}]

        }),
        methods: {
            fetchProducts() {

                axios.get('http://beerspecialist.azurewebsites.net/api/beer?land=dansk&top3=true')
                    .then((data) => {
                        this.productsdk = data.data;

                    });
                axios.get('http://beerspecialist.azurewebsites.net/api/beer?land=norsk&top3=true')
                    .then((data) => {
                        this.productsno = data.data;

                    });
                axios.get('http://beerspecialist.azurewebsites.net/api/beer?land=svensk&top3=true')
                    .then((data) => {
                        this.productsse = data.data;

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