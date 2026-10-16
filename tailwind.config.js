/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./Components/**/*.{razor,html,cshtml}",
    "./Pages/**/*.{razor,html,cshtml}",
    "./wwwroot/**/*.html"
  ],
  darkMode: 'class',
  theme: {
    extend: {
      colors: {
        minecraft: {
          dark: '#0d1117',
          card: '#161b22',
          cardHover: '#1f2937',
          border: '#30363d',
          gold: '#f59e0b',
          cyan: '#06b6d4',
          emerald: '#10b981',
          ruby: '#ef4444',
          amethyst: '#8b5cf6',
          sapphire: '#3b82f6'
        }
      },
      fontFamily: {
        sans: ['system-ui', '-apple-system', 'BlinkMacSystemFont', '"Segoe UI"', 'Roboto', 'Oxygen', 'Ubuntu', 'Cantarell', 'sans-serif'],
        mono: ['ui-monospace', 'SFMono-Regular', 'Menlo', 'Monaco', 'Consolas', 'monospace']
      }
    },
  },
  plugins: [],
}
