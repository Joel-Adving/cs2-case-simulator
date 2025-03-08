import tailwindcss from '@tailwindcss/vite';

// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  compatibilityDate: '2024-11-01',
  devtools: { enabled: true },
  css: ['~/assets/main.css'],
  vite: {
    plugins: [tailwindcss()],
  },
  modules: ['@pinia/nuxt', 'pinia-plugin-persistedstate/nuxt', '@nuxtjs/sitemap'],
  piniaPluginPersistedstate: {
    storage: 'localStorage',
  },
  site: {
    url: 'https://case.oki.gg',
    name: 'CS2 Case Simulator',
  },
  nitro: {
    preset: 'bun',
    prerender: {
      crawlLinks: true,
    },
  },
  routeRules: {
    '/': { prerender: true, isr: { expiration: 86400 } },
    '/stickers': { prerender: true, isr: { expiration: 86400 } },
    '/souvenirs': { prerender: true, isr: { expiration: 86400 } },
    '/autographs': { prerender: true, isr: { expiration: 86400 } },
    '/crate/**': { prerender: true, isr: { expiration: 86400 } },
    '/inventory': { prerender: true },
  },
  runtimeConfig: {
    public: {
      imageUrl: 'https://images.oki.gg/',
      baseUrl: 'https://case.oki.gg/',
    },
  },
  $development: {
    runtimeConfig: {
      public: {
        apiUrl: 'http://localhost:5015',
      },
    },
  },
  $production: {
    runtimeConfig: {
      public: {
        apiUrl: 'https://caseapi.oki.gg',
      },
    },
  },
});
