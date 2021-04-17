<template>
  <div v-bind:key="selectedBook.isbn">
    <h2 class="book-title">{{ selectedBook.title }}</h2>
    <img v-if="selectedBook.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + selectedBook.isbn + '-M.jpg'" />
    <h3 class="book-author">{{ selectedBook.author }}</h3>
    <p v-if="selectedBook.read">I have read this book</p>
    <p v-if="!selectedBook.read">I have not read this book</p>
  </div>
</template>

<script>
export default {
    name: "book-details",
    computed: {
        selectedBook() {
            return this.$store.state.books.find((selectedBook) => {
                return selectedBook.isbn === this.$route.params.id;
            });
        }
    }
}
</script>

<style>

</style>