<template>
  <div id="app">
    <div>
      <home></home>
    </div>
  </div>
</template>

<script>
import Home from "./views/Home.vue";
export default {
  Components: { Home },
  data() {
    return {
      cart: [],
    };
  },
};
</script>

<style>
@import url("https://fonts.googleapis.com/css2?family=Orbitron&display=swap");

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
  background-image: url("./assets/background.jpg");
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-size: cover;
}
</style>
