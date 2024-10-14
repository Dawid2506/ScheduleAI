<template>
  <div>
    <Button @click="fetchWeatherData" />
    <h1>Dane o pogodzie</h1>
    <p>Łącznie: {{ weatherData.length }}</p>
    <ul v-if="weatherData.length">
      <li v-for="(weather, index) in weatherData" :key="index">
        Data: {{ weather.date }}, Temperatura: {{ weather.temperatureC }}°C, Opis: {{ weather.summary }}
      </li>
    </ul>
  </div>
</template>

<script setup lang="ts">
import { ref, onMounted } from 'vue';
import axios from 'axios';

const weatherData = ref<any[]>([]);

const fetchWeatherData = async () => {
  try {
    const response = await axios.get('https://localhost:5001/WeatherForecast');
    weatherData.value = response.data;
  } catch (error) {
    console.error('Błąd podczas pobierania danych:', error);
  }
};

onMounted(() => {
  fetchWeatherData();
});
</script>
