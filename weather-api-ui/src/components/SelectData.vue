<template>
	<select name="cities" @change="valueChanged($event)" class="form-select form-control">
		<option value="" disabled selected hidden> {{ placeholder }} </option>
    <option v-bind:key="d" v-for="d in data"> {{ d }} </option>
	</select>
</template>

<script>
export default {
  props: {
    placeholder: String,
    data: Array,
  },
  methods:
  {
    valueChanged(e){
      this.$emit('data-changed', e.target.value);
    }
  }
}
</script>

