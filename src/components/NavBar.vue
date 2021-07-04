<template>
  <v-app-bar flat>
    <v-toolbar-title class="text-uppercase">
      <span class="light-text">GAME</span>
      <span>SHOP</span>
    </v-toolbar-title>
    <v-spacer></v-spacer>
    <v-icon class="nav-icon">mdi-cart-outline</v-icon>
    <v-icon class="nav-icon">fas fa-lock</v-icon>
    <v-icon class="nav-icon">fas fa-lock</v-icon>

  </v-app-bar>
</template>

<script>
export default {
    name: "NavBar",
};
</script>

<style>
.light-text{
  color: #18A558;
}

.v-icon.v-icon{
  color: #18A558 !important;
}
</style>
