<template>
  <div class="text-center mt-4">
    <a href="#" class="text-blue-600 font-medium hover:underline" @click.prevent="onSwitch">
      {{
        currentMode === 'login' ? 'Chưa có tài khoản? Tạo tài khoản' : 'Đã có tài khoản? Đăng nhập'
      }}
    </a>
  </div>
</template>

<script setup lang="ts">
import { defineProps, defineEmits } from 'vue'

defineProps({
  currentMode: {
    type: String,
    required: true,
  },
})

const emit = defineEmits(['switch'])

function onSwitch() {
  emit('switch')
}
</script>
