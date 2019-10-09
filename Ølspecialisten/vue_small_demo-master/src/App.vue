<template>
  <div id="app">
    <div id="nav">
      <router-link to="/">Read</router-link> |
      <router-link to="/albums">Delete</router-link> |
      <router-link to="/about">Create</router-link> |
      <router-link to="/shoes">Update</router-link>
    </div>
    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App',
  components: {},
  data: () => ({
    //
  }),
};
</script>

<style>
  #app {
    font-family: 'Avenir', Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
    margin-top: 60px;
  }
</style>
