USE assessment;
GO

-- Select all columns from posts that are published
SELECT *
FROM assessment.dbo.posts
WHERE published = 1;
-- Select posted_by and body from comments that have a body and were created after Oct. 15, 2019
SELECT posted_by, body
FROM assessment.dbo.comments
WHERE body IS NOT NULL AND created > '2019-10-15';
-- Select the name and published states from posts ordered by when they were created, earliest first
SELECT name, published
FROM assessment.dbo.posts
ORDER BY created;
-- Select the created date and the count of all the comments created on that date
SELECT created, COUNT(created) as posts_per_day
FROM assessment.dbo.comments
GROUP BY created;
-- Select the post name, comment posted_by and comment body for all posts created after Oct. 1st, 2019
SELECT p.name, c.posted_by, c.body
FROM assessment.dbo.posts p
JOIN assessment.dbo.comments c ON p.id = c.post_id
WHERE p.created > '2019-10-01';