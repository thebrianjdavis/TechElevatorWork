import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../views/Home.vue';
import MyBooks from '../views/MyBooks.vue';
import NewBook from '../views/NewBook.vue';
import BookDetailView from '../views/BookDetailView.vue';

Vue.use(VueRouter);

const routes = [
{
  path: '/',
  component: Home,
  name: 'Home'
},
{
  path: '/myBooks',
  component: MyBooks,
  name: 'MyBooks'
},
{
  path: '/addBook',
  component: NewBook,
  name: 'NewBook'
},
{
  path: '/book/:id',
  component: BookDetailView,
  name: 'BookDetailViewer'
}
];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
