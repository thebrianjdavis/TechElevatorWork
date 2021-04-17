-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

INSERT INTO actor (first_name, last_name)
VALUES ('Hampton', 'Avenue');

INSERT INTO actor (first_name, last_name)
VALUES ('Lisa', 'Byway');

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

INSERT INTO film (title, release_year, language_id, length)
VALUES ('Euclidean PI', 2008, 1, 198)

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

INSERT INTO film_actor (actor_id, film_id)
VALUES (201, 1002)

INSERT INTO film_actor (actor_id, film_id)
VALUES (202, 1002)
--Hampton is actor_id is 201
--Lisa is actor_id is 202
--Euclidean PI film_id is 1002

-- 4. Add Mathmagical to the category table.

INSERT INTO category (name)
VALUES ('Mathmagical');

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

INSERT INTO film_category (category_id, film_id)
VALUES (17, 1002)

UPDATE film_category
SET category_id = 17
WHERE film_id = 1002 OR film_id = 274 OR film_id = 494 OR film_id = 714 OR film_id = 996;

--Mathmagical category_id is 17
--Euclidean PI film_id is 1002
--EGG IGBY film_id is 274
--KARATE MOON film_id is 494
--RANDOM GO film_id is 714
--YOUNG LANGUAGE film_id is 996

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE film
SET rating = 'G'
FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
WHERE fc.category_id = 17;

-- 7. Add a copy of "Euclidean PI" to all the stores.

INSERT INTO inventory (film_id, store_id)
VALUES (1002, 1)

INSERT INTO inventory (film_id, store_id)
VALUES (1002, 2)

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.

DELETE FROM film
WHERE film_id = 1002;

-- (Did it succeed? Why?)

--It did not delete it from the film table because there are still multiple
--foreign key references to its primary key 'film_id'

-- 9. Delete Mathmagical from the category table.

DELETE FROM category
WHERE category_id = 17;

-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
--It did not delete it from the category table because there is still a
--foreign key reference to its primary key 'category_id' on the
--film_category table

-- 10. Delete all links to Mathmagical in the film_category tale.

DELETE FROM film_category
WHERE category_id = 17;

-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
--It worked this time because it is terminating the foreign key links between
--the film and category tables

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".

DELETE FROM category
WHERE category_id = 17;

DELETE FROM film
WHERE film_id = 1002;

-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
--The category was able to be deleted because the primary key was no longer referenced
--on the film_category table, however the film cannot yet be deleted because the primary
--key (film_id) is still referenced as a foreign key on the film_actor table and the
--inventory table

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--First, I would remove the film_id reference from the inventory table by searching for
--the inventory id and deleting it

DELETE FROM inventory
WHERE film_id = 1002;

--Second, I would remove the film_id reference from the film_actor table to terminate the
--link (foreign key reference to film_id)

DELETE FROM film_actor
WHERE film_id = 1002;

--Lastly, the film can finally be deleted from the film table since the film_id would no
--longer be referenced on another table as a foreign key

DELETE FROM film
WHERE film_id = 1002;
