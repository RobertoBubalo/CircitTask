<template>
    <div>
        <h1>Astronomy data</h1>
        <dl>
            <dt>Sunrise</dt>
            <dd>{{astroData.astronomy.astro.sunrise}}</dd>
        </dl>

        <timezone-info :tz-data="astroData.location" />
    </div>
</template>

<script>
import TimezoneInfo from "../components/TimezoneInfo.vue";

export default {
    components: {
        TimezoneInfo,
    },
  props: {
    astroData: Object,
  },
}
</script>

