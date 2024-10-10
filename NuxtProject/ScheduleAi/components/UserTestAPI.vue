<template>
    <div>
        <h2>Prognoza Pogody</h2>
        <button @click="fetchWeatherForecast">Pobierz prognozę</button>
        <ul v-if="forecasts.length > 0">
            <li v-for="forecast in forecasts" :key="forecast.id">
                <strong>{{ forecast.date }}</strong>: {{ forecast.summary }} ({{ forecast.temperatureC }}°C)
            </li>
        </ul>
        <p v-else>Brak danych do wyświetlenia.</p>
    </div>
</template>

<script setup lang="ts">
import { ref } from 'vue';
import axios from 'axios';

interface Forecast {
    id: number;
    date: string;
    summary: string;
    temperatureC: number;
}

const forecasts = ref<Forecast[]>([]); // Ref to hold weather forecast data

// Function to fetch weather forecast data
const fetchWeatherForecast = async () => {
    try {
        const response = await axios.get('https://localhost:5001/WeatherForecast');
        forecasts.value = response.data; // Set the fetched data to the forecasts ref
    } catch (error) {
        console.error('Błąd podczas pobierania prognozy pogody:', error);
    }
};
</script>

<style scoped>
button {
    margin-bottom: 1rem;
    padding: 0.5rem 1rem;
    background-color: #007bff;
    color: white;
    border: none;
    border-radius: 5px;
    cursor: pointer;
}

button:hover {
    background-color: #0056b3;
}

ul {
    list-style-type: none;
    padding: 0;
}

li {
    padding: 0.5rem 0;
}
</style>
