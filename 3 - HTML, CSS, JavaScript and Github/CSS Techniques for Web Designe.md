.container {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-wrap: wrap;
}

.grid-container {
    grid-template-rows: auto;
    grid-template-columns: 1fr 1fr;
    grid-gap: 10px;
}

.grid-item {
    display: flex;
    justify-content: space-between;
}

.button {
    transition: background-color 0.5s ease;
}

.button:hover {
    background-color: #333;
}

@keyframes slide {
    from { transform: translateX(0); }
    to { transform: translateX(100px); }
}

.animated-element {
    animation: slide 2s ease-in-out;
}

.button:hover {
    transform: scale(1.1);
}

@media (max-width: 768px) {
    .grid-container {
        grid-template-columns: 1fr;
    }
}