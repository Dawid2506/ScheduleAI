<template>
    <div class="bg-red-700">
        <Button @click="fetchData" />
        <p>hello from aiTalk {{ message }}</p>
    </div>
</template>

<script setup lang="ts">
import axios from 'axios';
const message = ref('');

const fetchData = async () => {
    console.log('fetchData');
    try {
        const response = await axios.get('http://localhost:5000/get-data');
        message.value = response.data.message;
    } catch (error) {
        console.log('Błąd podczas pobierania danych:', error);
    }
};

onMounted(() => {
    fetchData();
});
// make search in file site
</script>

