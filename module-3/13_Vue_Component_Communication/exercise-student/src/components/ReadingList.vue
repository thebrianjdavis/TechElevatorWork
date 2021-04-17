<template>
  <div class="book-container">
    <book-card
      v-for="book in filteredBooks"
      v-bind:key="book.isbn"
      v-bind:book="book"
      />
  </div>
</template>

<script>
import BookCard from "./BookCard.vue";

export default {
    name: 'reading-list',
    components: {
      BookCard
    },
    computed: {
      filteredBooks(){
        const books = this.$store.state.books;
        return books;
      }
    }
}
</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>