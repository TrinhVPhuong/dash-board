<script setup lang="ts">
import { reactive, ref } from 'vue'
import FormInput from '@/components/common/FormInput.vue'
import AppButton from '@/components/AppButton.vue'

const props = defineProps({
  formType: {
    type: String,
    required: true,
  },
  formData: {
    type: Object,
    default: () => ({}), // Provide a default empty object
  },
})

const emit = defineEmits(['submit'])
const localFormData = reactive({ ...props.formData }) // Access formData via props
const errors = ref({ email: '', password: '', general: '' })
const isLoading = ref(false)

function validateForm() {
  errors.value.email = !localFormData.email?.trim()
    ? 'Email is required'
    : !/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(localFormData.email)
      ? 'Invalid email format'
      : ''
  errors.value.password = !localFormData.password?.trim() ? 'Password is required' : ''
  return !errors.value.email && !errors.value.password
}

async function handleSubmit() {
  if (!validateForm()) return
  isLoading.value = true
  try {
    // Simulate API call
    await new Promise((resolve) => setTimeout(resolve, 1000))
    emit('submit', { ...localFormData })
  } catch {
    errors.value.general = 'Login failed. Please try again.'
  } finally {
    isLoading.value = false
  }
}
</script>

<template>
  <form @submit.prevent="handleSubmit">
    <div class="flex aligin-center gap-4 mb-4 w-full">
      <FormInput type="text" placeholder="Họ và tên đệm" v-model="localFormData.lastName" />
      <FormInput type="text" placeholder="Tên" v-model="localFormData.firstName" />
    </div>
    <div class="flex aligin-center gap-4 mb-4 w-full">
      <FormInput type="email" placeholder="Email" v-model="localFormData.email" />
    </div>
    <div class="flex aligin-center gap-4 mb-4 w-full">
      <FormInput type="password" placeholder="Mật khẩu" v-model="localFormData.password" />
    </div>
    <div class="flex aligin-center gap-4 mb-4 w-full">
      <FormInput
        type="password"
        placeholder="Xác nhận mật khẩu"
        v-model="localFormData.confirmPassword"
      />
    </div>

    <template v-if="formType === 'alternate'">
      <FormInput type="text" placeholder="Enter your username" v-model="localFormData.email" />
    </template>
    <template v-else>
      <FormInput
        type="password"
        placeholder="Enter your password"
        v-model="localFormData.password"
      />
    </template>
    <div v-if="isLoading" class="flex justify-center mb-4">
      <span class="loading loading-spinner loading-md"></span>
    </div>
    <p v-if="errors.general" class="text-red-500 text-sm text-center mb-4" aria-live="polite">
      {{ errors.general }}
    </p>
    <AppButton
      :label="isLoading ? 'Loading...' : formType === 'default' ? 'Đăng nhập' : 'Đăng ký'"
      :disabled="isLoading"
      type="submit"
      variant="primary"
      class="btn w-full h-12 mt-4"
    />
  </form>
</template>
