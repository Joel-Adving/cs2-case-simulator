<script setup lang="ts">
defineOptions({ name: 'BaseContainer' });
</script>

<template>
    <div class="w-full max-w-5xl sm:px-4 mx-auto">
        <div
            class="relative w-full pt-0 sm:pt-4 py-4 mx-auto backdrop-blur-xs bg-black/40 sm:my-4 sm:rounded-xl sm:shadow-xl shadow-none sm:border border-black/10 border-none"
        >
            <slot></slot>
        </div>
    </div>
</template>
