fetch('https://jsonplaceholder.typicode.com/users')
    .then(response => response.json())
    .then(data => {
        const container = document.getElementById('users-container');
        data.forEach(user => {
            const userElement = document.createElement('p');
            userElement.textContent = `${user.name} - ${user.email}`;
            container.appendChild(userElement);
        });
    })
    .catch(error => console.error('Error fetching data:', error));