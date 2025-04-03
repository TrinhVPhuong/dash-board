<script setup lang="ts">
import AuthForm from './components/AuthForm.vue'
import AuthHeader from './components/AuthHeader.vue'
import AuthFooter from './components/AuthFooter.vue'

const formData = {
  email: '',
  password: '',
}

function handleLogin(data: { email: string; password: string }) {
  console.log('Login successful with data:', data)
}
</script>

<template>
  <main
    class="flex items-center justify-center min-h-screen bg-gradient-to-l from-gray-500 via-neutral-400 to-500"
  >
    <div
      class="flex justify-center items-center h-full p-4 bg-gradient-to-b from-neutral-900 via-neutral-800 to-neutral-900 rounded-2xl shadow-4xl max-w-8xl w-4/5"
    >
      <div
        class="flex h-200 w-1/2 bg-[url('@/assets/images/login_image.jpg')] bg-cover bg-center rounded-2xl"
      ></div>
      <div class="card p-6 pl-12 text-white flex items-center h-full w-1/2">
        <AuthHeader class="self-start" title="Tạo tài khoản" />
        <AuthForm formType="default" :formData="formData" @submit="handleLogin" />
        <AuthFooter />
      </div>
    </div>
  </main>
</template>
