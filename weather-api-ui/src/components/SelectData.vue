<template>
	<select name="cities" @change="valueChanged($event)" :class="getClasses()">
		<option value="" disabled selected hidden> {{ placeholder }} </option>
    <option v-bind:key="d" v-for="d in data"> {{ d }} </option>
	</select>
</template>

<script>
export default {
  props: {
    placeholder: {
      default: 'Select',
      type: String,
    },
    data: Array,
    block: Boolean,
  },
  methods:
  {
    valueChanged(e){
      this.$emit('data-changed', e.target.value);
    },
    getClasses(){
      const baseClass = "container__weatherapi__select";
      const sizeClass = baseClass + "-" + (this.block ? "block" : "small");
      return [baseClass, sizeClass]
    },
  }
}
</script>

<style lang="scss" scoped>
.container__weatherapi__select {
  padding: 0.2rem;
  margin: 0.2rem;

  &-block {
    width: 80%;;
  }
  &-small {
    width: 40%;
  }
}
</style>
