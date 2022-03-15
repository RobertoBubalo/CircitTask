<template>
  <card-component :title='"Timezone data"' :cardData="Object.values(tzData)" />
</template>

<script>
import CardComponent from "./CardComponent.vue"

export default {
    components: {
      CardComponent,
  },
  props: {
    tzData: Object,
  },
}
</script>

