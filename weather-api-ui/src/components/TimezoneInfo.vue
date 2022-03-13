<template>
  <div>
    <h1>Timezone data</h1>
    <dl>
      <dt>City</dt>
      <dd>{{tzData.name}}</dd>

      <dt>Region</dt>
      <dd>{{tzData.region}}</dd>

      <dt>Country</dt>
      <dd>{{tzData.country}}</dd>

      <dt>Lat & Lon</dt>
      <dd>{{tzData.lat}} | {{tzData.lon}}</dd>

      <dt>Local Time</dt>
      <dd>{{tzData.localTime}}</dd>
    </dl>
  </div>
</template>

<script>
export default {
  props: {
    tzData: Object,
  },
}
</script>

