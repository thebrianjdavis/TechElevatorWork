<template>
  <div>
      <form v-on:submit.prevent="addNewBook" v-if="showForm" class="new-book-form">
          <div class="form-element">
              <label for="title">Title:</label>
              <input class="title-input" id="title" type="text" v-model="newBook.title" />
          </div>
          <div class="form-element">
              <label for="author">Author:</label>
              <input class="author-input" id="author" type="text" v-model="newBook.author" />
          </div>
          <div class="form-element">
              <label for="isbn">ISBN:</label>
              <input class="isbn-input" id="isbn" type="text" v-model="newBook.isbn" />
          </div>
          <input type="submit" value="Save" />
          <input type="button" value="Cancel" v-on:click.prevent="resetForm" />
      </form>
  </div>
</template>

<script>
export default {
    name: "add-book",
    data() {
    return {
      showForm: true,
      newBook: {
        read: false,
      },
    };
  },
  methods: {
    addNewBook() {
      this.$store.commit("ADD_BOOK", this.newBook);
      this.resetForm();
    },
    resetForm() {
      this.newBook = {};
    },
  },
}
</script>

<style>
div.form-element {
  margin-top: 10px;
}
div.form-element > label {
  display: block;
}
div.form-element > input,
div.form-element > select {
  height: 30px;
  width: 300px;
}
form > input[type="button"] {
  width: 100px;
}
form > input[type="submit"] {
  width: 100px;
  margin-right: 10px;
}
</style>