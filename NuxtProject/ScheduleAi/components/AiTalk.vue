<template>
    <div class="bg-red-700">
        <Button @click="fetchData" />
        <p>hello from aiTalk {{ message }}</p>
    </div>
</template>

<script setup lang="ts">
import axios from 'axios';
const message = ref('');

// Funkcja do pobierania danych z serwera Pythona
const fetchData = async () => {
    console.log('fetchData');
    try {
        const response = await axios.get('http://localhost:5000/get-data');
        message.value = response.data.message;  // Przypisanie wartości do ref
    } catch (error) {
        console.log('Błąd podczas pobierania danych:', error);
    }
};

// Wywołanie fetchData po zamontowaniu komponentu
onMounted(() => {
    fetchData();
});
</script>
