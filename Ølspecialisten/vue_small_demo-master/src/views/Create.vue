<template>
  <div>
    <h1>CREATE NEW CUP TO OUR SHOP</h1>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <body>

    <form class="w3-container w3-card-4" action="">
      <h2 class="w3-text-black">Input data under</h2>
      <p>Fill the text fields with the correct data</p>
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

        <button class="w3-btn w3-blue"  @click="Post">Register</button></p>
    </form>

    </body>

  </div>
</template>
<script>
  import axios from 'axios';
  export default {
    mounted() {
      this.Post()
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

      }
    },
    methods: {
      Post() {

        axios.post('http://beerspecialist.azurewebsites.net/api/beer', {
          navn: this.navn,
          pris: +this.pris,
          beskrivelse: this.beskrivelse,
          nation: this.nation,
          lager: +this.lager,
          beskrivelseLang: this.beskrivelseLang,
          alkohol: +this.alkohol,
          kapacitet: +this.kapacitet,
          typeOfBeer: this.typeOfBeer,
          titel: this.titel,
          image64: this.image64
        })

      }
    }
  };
</script>