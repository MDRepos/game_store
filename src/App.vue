<template>
  <div>
    <nav-bar></nav-bar>
    <router-view></router-view>
  </div>
</template>

<script>
import NavBar from "./components/NavBar.vue";
import Home from "./views/Home.vue";
export default {
  name: "App",
  components: { NavBar, Home },
  data: () => ({
    //
  }),
};
</script>
<style>
#app {
  color: #18a558;
  background-color: #f5f5f5;
}
</style>
