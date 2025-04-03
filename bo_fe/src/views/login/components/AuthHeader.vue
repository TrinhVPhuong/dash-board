<template>
  <header class="mb-6 text-white">
    <h1 class="text-3xl font-bold">{{ title }}</h1>
    <SwitchAuthLink currentMode="login" @switch="handleSwitch" />
  </header>
</template>

<script setup lang="ts">
import { defineProps } from 'vue'
import SwitchAuthLink from '../components/SwitchAuthLink.vue'

defineProps({
  title: {
    type: String,
    required: true,
  },
})

function handleSwitch() {}
</script>
