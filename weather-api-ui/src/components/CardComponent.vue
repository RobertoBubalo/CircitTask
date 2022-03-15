<template>
    <div class="card">
        <div class="container">
            <h4 v-if='title'><strong>{{ title }}</strong></h4>
            <p v-bind:key="cd" v-for="cd in cardData">{{cd}}</p>
        </div>
    </div>
</template>

<script>
export default {
  props: {
    cardData: Array,
    title: String,
  },
}
</script>
<style scoped>
.card {
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
  transition: 0.3s;
  width: 40%;
  margin: auto;
}

.card:hover {
  box-shadow: 0 12px 20px 0 rgba(0,0,0,0.2);
}

.container {
  padding: 2px 16px;
}
</style>

