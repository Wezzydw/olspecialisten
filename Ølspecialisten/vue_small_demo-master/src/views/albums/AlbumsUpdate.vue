<template>
    <v-form v-model="valid">
        <v-container>
            <v-row no-gutters>
                <v-col
                        md="4"
                        offset-md="4">
                    <v-card  class="pa-2"
                             color="primary"
                            outlined
                            tile>
                        <v-card-title>New Album</v-card-title>
                        <v-card-text>
                            <v-text-field
                                    v-model="title"
                                    label="Title"
                                    required
                            ></v-text-field>
                            <v-select
                                    :menu-props="{ top: true, offsetY: true }"
                                    v-model="userId"
                                    :items="users"
                                    item-text="name"
                                    item-value="id"
                                    label="Owner">
                            </v-select>
                        </v-card-text>
                        <v-card-actions>
                            <v-row no-gutters>
                                <v-col
                                        md="2"
                                        offset-md="10">
                                    <v-btn text v-on:click="save()">
                                        <v-icon>mdi-content-save-outline </v-icon>
                                        Save</v-btn>
                                </v-col>
                            </v-row>

                        </v-card-actions>
                    </v-card>
                </v-col>
            </v-row>
        </v-container>
    </v-form>
</template>

<script>
    import restApi from '../../api/api'
    export default {
        mounted() {

        },
        data: ()  => ({
            valid:true,
            userId: 1,
            title: '',
            users:  [
                { name: 'John', id: 1 },
                { name: 'Jack', id: 2 },
                { name: 'Jill', id: 3 }
             ]
        }),
        methods: {
            save() {
                const baseURI = 'https://jsonplaceholder.typicode.com/albums'
                restApi.post(baseURI, {
                    title: this.title,
                    userId: this.userId
                })
                    .then((result) => {
                        console.log(result);
                    })
            }
        }
    };
</script>
