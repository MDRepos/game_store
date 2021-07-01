<template>
  <div id="app">
      <home></home>


    </div>
  </div>
</template>

<script>
import Home from "./views/Home.vue";
export default {
  components: { Home },
  data() {
    return {
      cart: [],

    };
  },
      methods: {

    }
};
</script>

<style>

#app {
  font-family: "Orbitron", Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #03d930;
  margin: 0;
  padding: 0;
}

body {

}
</style>
