<!-- src/components/Weather.vue -->
<template>
  <div>
    <h1>Weather Data</h1>
    <ul>
      <li v-for="(item, index) in weatherData" :key="index">{{ item }}</li>
    </ul>
    <div v-if="error" class="error">{{ error }}</div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      weatherData: [],
      error: null
    };
  },
  created() {
    fetch('http://localhost:5000/weatherforecast')
      .then(response => {
        if (!response.ok) {
          throw new Error(`HTTP error! Status: ${response.status}`);
        }
        return response.json();
      })
      .then(data => {
        this.weatherData = data;
      })
      .catch(error => {
        this.error = `Failed to fetch weather data: ${error.message}`;
      });
  }
};
</script>

<style>
.error {
  color: red;
}
</style>





<!-- <template>
  <img alt="Vue logo" src="./assets/logo.png">
  <HelloWorld msg="Welcome to Your Vue.js App"/>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'

export default {
  name: 'App',
  components: {
    HelloWorld
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style> -->
