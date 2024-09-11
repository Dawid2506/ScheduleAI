<template>
    <div>
        <p class="text-sm text-red-600"> tsest </p> <!-- poprawnie: class -->
        <Button class="bg-red-800" label="Check" icon="pi pi-check" />
    </div>
    <div class="bg-blue-500 text-white p-4">
        <label>
            <AiTalk />
            {{ test }}
        </label>
    </div>
</template>

<script setup lang="ts">

const test = ref<string>('Tessddasdast');
</script>