<template>
    <div>
        <h2>Dodaj użytkownika</h2>
        <form @submit.prevent="createUser">
            <InputText v-model="user.eMail" type="email" placeholder="Email" required />
            <InputText v-model="user.login" type="text" placeholder="Login" required />
            <InputText v-model="user.password" type="password" placeholder="Password" required />
            <button type="submit">Dodaj użytkownika</button>
        </form>
    </div>
</template>


<script setup lang="ts">
import { ref } from 'vue';
import axios from 'axios';

const user = ref({
    eMail: '',
    login: '',
    password: ''
});

const createUser = async () => {
    console.log('użytkownik:', user.value.eMail, user.value.login, user.value.password);
    try {
        const response = await axios.post('http://localhost:32769/User', user.value);
        console.log('Użytkownik zapisany:', response.data);
    } catch (error) {
        console.error('Błąd podczas zapisywania użytkownika:', error);
    }
};
</script>
