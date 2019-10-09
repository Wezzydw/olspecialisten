<template>

    <v-container>

        <v-row no-gutters>
            <v-snackbar
                    v-model="deletedSuccess">
                {{ deletedText }}
                <v-btn
                        color="pink"
                        text
                        @click="deletedSuccess = false"
                >Close</v-btn>
            </v-snackbar>
            <v-col
                    md="6"
                    offset-md="3">
                <v-card  class="pa-2"
                         color="primary"
                         outlined
                         tile>
                    <v-card-title>
                        <v-row no-gutters>
                            <v-col
                                    md="1">
                                <router-link to="/albums-create" tag="button">
                                    <v-icon>mdi-plus-circle </v-icon>
                                </router-link>
                            </v-col>
                            <v-col justify="center" md="12">Albums</v-col>
                        </v-row>
                    </v-card-title>
                    <v-card-text>
                        <v-list>
                            <v-list-item-group color="primary"
                                               v-for="album in albums"
                                               :key="album.navn">
                                <v-list-item>
                                    <v-list-item-avatar>
                                        <v-img v-bind:src="'https://picsum.photos/id/' + album.id + '/40'"></v-img>
                                    </v-list-item-avatar>

                                    <v-list-item-content>
                                        <v-list-item-title>{{album.navn}}</v-list-item-title>
                                    </v-list-item-content>

                                    <v-list-item-action>
                                        <v-col>
                                            <v-btn icon>
                                                <v-icon color="grey lighten-1">mdi-circle-edit-outline</v-icon>
                                            </v-btn>
                                            <v-btn v-on:click="deleteAlbum(album)" icon>
                                                <v-icon color="grey lighten-1">mdi-minus-circle-outline</v-icon>
                                            </v-btn>
                                        </v-col>

                                    </v-list-item-action>
                                </v-list-item>
                                <v-divider inset></v-divider>
                            </v-list-item-group>
                        </v-list>
                    </v-card-text>
                    <v-card-actions>
                        <v-row no-gutters>
                            <v-col
                                    md="2"
                                    offset-md="10">

                            </v-col>
                        </v-row>

                    </v-card-actions>
                </v-card>
            </v-col>
        </v-row>
    </v-container>
</template>

<script>
    import restApi from '../../api/api'
    export default {
        components: { },
        mounted() {
            this.fetchAlbums()
        },
        data () {
            return {
                albums: [],
                deletedSuccess: false,
                deletedText: 'Album deleted'
            }
        },
        methods: {
            fetchAlbums() {
                restApi.get('navn')
                    .then((result) => {
                        if (this.albums && this.albums.length > 0){
                            this.albums = this.albums.filter(a => result.data.some(an => an.id === a.id));
                        } else{
                            this.albums = result.data
                        }
                    })
            },
            async deleteAlbum(album) {
                let result = await restApi.delete('albums/'+album.id)
                this.deletedSuccess = true;
                if(result.status !== 200) {
                    // this.albums.push(album)
                } else {
                    this.fetchAlbums()
                }

            }
        }
    };
</script>
