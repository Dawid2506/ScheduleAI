<template>
    <div>
        <UserTestAPI />
        <APIconnect />
        <p class="text-sm text-red-600"> tsest </p> <!-- poprawnie: class -->
        <Button class="bg-red-800" label="Check" icon="pi pi-check" />
    </div>
    <div class="bg-blue-500 text-white p-4">
        <label>
            <AiTalk />
            {{ test }}
        </label>
    </div>
    <div class="bg-[rgb(245,245,220)]">
dasdsa
    </div>
    <div class="bg-[rgb(229,212,190)]">
dasdsa
    </div>
    <div class="bg-[rgb(218,187,147)]">
dasdsa
    </div>

    <div class="bg-[rgb(245,245,220)] h-40 w-40 flex justify-center items-center">
        <div class="bg-[rgb(229,212,190)] h-36 w-36">dasd</div>
    </div>
</template>

<script setup lang="ts">
import APIconnect from './APIconnect.vue';
import UserTestAPI from './UserTestAPI.vue';


const test = ref<string>('Tessddasdast');
</script>