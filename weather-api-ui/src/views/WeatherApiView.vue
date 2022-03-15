<template>
  <div class="container__weatherapi">
    <select-data :data="cities" :block="true" @data-changed="cityChanged" placeholder='Select a City'></select-data>
    <select-data :data="info" @data-changed="infoChanged" placeholder='Select information'></select-data>

    <timezone-info v-if="show == 'Timezone'" :tz-data="cityData.location" />
    <astronomy-info v-else-if="show == 'Astronomy'" :astro-data="cityData" />
    <div v-else-if="show == 'Current'"><h1>Implementation for current weather...</h1></div>
    
  </div>
</template>

<script>
import SelectData from "../components/SelectData.vue";
import TimezoneInfo from "../components/TimezoneInfo.vue";
import AstronomyInfo from "../components/AstronomyInfo.vue";

export default {
  cityData: Object,
  components: {
    SelectData,
    TimezoneInfo,
    AstronomyInfo,
  },
  data() {
    return {
      cities: ["Dublin", "London", "Paris" ],
      info: ["Current", "Astronomy", "Timezone" ],
      selectedCity: "",
      selectedInfo: "",
      show: "",
    }
  },
  methods: {
    async cityChanged(val)
    {
      this.selectedCity = val;
      await this.fetchData();
      if (this.selectedInfo != '')
      {
        // this should just be used to refersh component if the type of info is same but we are changing the data
        // multiple nice solutions, e.g. using keys
        this.$forceUpdate(); 
      }
    },
    infoChanged(val)
    {
      this.selectedInfo = val;
      this.fetchData();
    },
    async fetchData()
    {
      if (this.selectedCity == '' || this.selectedInfo == '') return;

      // this data should be fetched by computed property from the vuex store after we dispatch an action to get it from the api
      const res = await fetch("api/" + this.selectedInfo + "?city=" + this.selectedCity)
      const data = await res.json();
      this.show = this.selectedInfo;
      this.cityData = data;
    }
  }
}
</script>

<style scoped>
.container__weatherapi {
  margin: auto;
  width: 50%;
  padding: 1rem;
}
</style>