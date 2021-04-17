let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

function makeComplete(e) {
  e.setAttribute('class', '.completed');
}

document.addEventListener("DOMContentLoaded",

  () => {

    const ul = document.querySelector('ul');
    ul.addEventListener("click",
      (event) => {
        event.target.classList.add('completed');
        const i = event.target.querySelector('i');
        i.classList.add('completed');
      }
    )
    ul.addEventListener("dblclick",
      (event) => {
        event.target.removeAttribute('class');
        const i = event.target.querySelector('i');
        i.classList.remove('completed');
      }
    )
    const toggleAll = document.getElementById('toggleAll');
    toggleAll.addEventListener("click",
      (event) => {
        const li = document.querySelectorAll('li');
        if (allItemsIncomplete) {
          li.forEach(element => {
            element.classList.add('completed');
            const i = element.querySelector('i');
            i.classList.add('completed');
            toggleAll.innerText = 'Mark All Incomplete';
            allItemsIncomplete = false;
          }
          )
        }
        else {
          li.forEach(element => {
            element.classList.remove('completed');
            const i = element.querySelector('i');
            i.classList.remove('completed');
            toggleAll.innerText = 'Mark All Complete';
            allItemsIncomplete = true;
          })
        }
      });
    setPageTitle();
    displayGroceries();
  }
)