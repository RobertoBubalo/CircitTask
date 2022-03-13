const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
  transpileDependencies: true,
  devServer: {
    proxy: {
        '^/api': {
            target: 'https://localhost:44374/api/',
            changeOrigin: true,
            logLevel: 'debug',
            pathRewrite: { '^/api': '' },
        },
    },
  },
})
