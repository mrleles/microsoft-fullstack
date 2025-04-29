const quoteDisplay = document.getElementById('quoteDisplay');
const newQuoteButton = document.getElementById('newQuoteButton');

const quotes = [
    'Your love is a lie.',
    'Nobody wanna see us together.',
    'I love the way you lie.'
]

newQuoteButton.addEventListener('click', () => {
    const counter = Math.floor(Math.random() * quotes.length);
    quoteDisplay.textContent = quotes[counter];
});