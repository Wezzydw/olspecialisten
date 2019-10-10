<template>
    <div>
        <h1>CREATE NEW CUP TO OUR SHOP</h1>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <body>

        <form class="w3-container w3-card-4" action="">
            <h2 class="w3-text-black">Input data under</h2>
            <p>Fill the text fields with the correct data</p>
            <p>
                <label class="w3-text-black"><b>id</b></label>
                <v-text-field
                        v-model="id"
                        label="id der skal slettes"
                        required
                ></v-text-field>
            <p>

                <button class="w3-btn w3-blue"  @click="Delete">Register</button></p>
        </form>

        </body>

    </div>
</template>
<script>
    import axios from 'axios';
    export default {
        mounted() {
            this.Delete()
        },
        data () {
            return {
                beer:[],
                id: +'',
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
            Delete() {

                axios.delete('http://beerspecialist.azurewebsites.net/api/beer/'+this.id, {
                    //id: this.id,

                })

            }
        }
    };
</script>