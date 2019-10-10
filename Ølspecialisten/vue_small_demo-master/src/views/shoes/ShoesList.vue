<template>
    <div>
        <h1>Update Beer to shop</h1>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
        <body>

        <form class="w3-container w3-card-4" action="">
            <h2 class="w3-text-black">Input data under</h2>
            <p>Fill the text fields with the correct data</p>
            <p>
                <label class="w3-text-black"><b>Id</b></label>
                <v-text-field
                        v-model="id"
                        label="id på øllen"
                        required
                ></v-text-field>

            <p>
                <label class="w3-text-black"><b>Navn</b></label>
                <v-text-field
                        v-model="navn"
                        label="Navn på øllen"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>Pris</b></label>
                <v-text-field>
                    v-model="pris"
                    label="prisen pr. øl"
                    required
                    ></v-text-field>
            <p>
                <label class="w3-text-black"><b>Beskrivelse(cl)</b></label>
                <v-text-field
                        v-model="beskrivelse"
                        label="Kort beskrivelse af øllen"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>Nation</b></label>
                <v-text-field
                        v-model="nation"
                        label="Hvilken nation er den fra?"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>Lager</b></label>
                <v-text-field
                        v-model="lager"
                        label="Hvor mange skal tilføjes til lager?"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>BeskrivelseLang</b></label>
                <v-text-field
                        v-model="beskrivelseLang"
                        label="En længere beskrivelse af øllen"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>Alkohol</b></label>
                <v-text-field
                        v-model="alkohol"
                        label="Hvor meget alkohol er der i?"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>Kapacitet</b></label>
                <v-text-field
                        v-model="kapacitet"
                        label="Hvor meget er der i øllen?"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>TypeOfBeer</b></label>
                <v-text-field
                        v-model="typeOfBeer"
                        label="Hvilken type?"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>Titel</b></label>
                <v-text-field
                        v-model="titel"
                        label="Øllens titel"
                        required
                ></v-text-field>
            <p>
                <label class="w3-text-black"><b>image64</b></label>
                <v-text-field
                        v-model="image64"
                        label="streng på øllens billede"
                        required
                ></v-text-field>
            <p>
                <router-link :to="{path:'/admin/'}"><v-btn @click="updateBeer">Update</v-btn></router-link></p>
        </form>

        </body>

    </div>
</template>

<script>
    import axios from 'axios';
    export default {
        mounted() {
            this.getBeer()
        },
        data () {
            return {
                beer:[],
                navn: '',
                pris: '',
                beskrivelse: '',
                nation: '',
                lager: '',
                beskrivelseLang: '',
                alkohol: '',
                kapacitet: '',
                typeOfBeer: '',
                titel: '',
                image64: '',
                id: this.$route.params.id
            }},
        methods: {
            getBeer() {
                axios.get('http://beerspecialist.azurewebsites.net/api/beer' + this.id)
                    .then((response) => {
                        let beer = response.data;
                        this.navn = beer.navn;
                        this.beskrivelse = beer.beskrivelse;
                        this.nation = +beer.nation;
                        this.lager = beer.lager;
                        this.beskrivelseLang = beer.beskrivelseLang;
                        this.alkohol = +beer.alkohol;
                        this.kapacitet = +beer.kapacitet;
                        this.typeOfBeer = beer.typeOfBeer;
                        this.titel = beer.titel;
                        this.image64 = beer.image64;
                        this.id = beer.id;
                    });
            },
            updateBeer() {
                axios.put('http://beerspecialist.azurewebsites.net/api/beer' + this.id, {
                    navn: this.navn,
                    beskrivelse: this.beskrivelse,
                    nation: this.nation,
                    lager: this.lager,
                    beskrivelseLang: this.beskrivelseLang,
                    alkohol: this.alkohol,
                    kapacitet: this.kapacitet,
                    typeOfBeer: this.typeOfBeer,
                    titel: this.titel,
                    image64: this.image64,
                    id: this.id,
                } );
            },
            fetchProducts() {
                axios.get('http://beerspecialist.azurewebsites.net/api/beer')
                    .then((data) => {
                        this.beer = data.data})
            }
        }
    };
</script>
