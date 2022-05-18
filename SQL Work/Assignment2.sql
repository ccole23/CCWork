use sakila;


select count(film.title)
from film;

select count(film.title)
from film, film_actor, actor
where film.film_id = film_actor.film_id
and film_actor.actor_id = actor.actor_id
and actor.first_name = "Nick"
And actor.last_name = "Wahlberg";

select film.title
from film
where rating = "pg";

select sum(payment.amount), staff.first_name, staff.last_name
from payment, staff
where staff.staff_id = payment.staff_id
group by staff.staff_id;

select avg(payment.amount), store.store_id
from store, payment 
group by store_id;

select count(film.title), film.rating
from film
group by rating
order by count(film.title) desc;

select film.rating, count(film.title) 
from film
group by rating <> ( 
	select count(film.title)
    );
    
select film.title
from film
where film.title like 'a__d%';
-- ACADEMY DINOSAUR ALADDIN CALENDAR and AMADEUS HOLY

select film.title
from film
where film.title like '%k%' or '%q%';

select film.title, concat(customer.first_name,' ',customer.last_name) as "Customer Name", customer.email, datediff(rental.return_date, rental.rental_date) - film.rental_duration as "Overdue by"
from film, rental, inventory, customer
where inventory.film_id = film.film_id
and customer.customer_id = rental.customer_id
and rental.inventory_id = inventory.inventory_id
and datediff(rental.return_date, rental.rental_date) > film.rental_duration;
-- L
select payment.customer_id, sum(payment.amount), payment_date
from payment 
group by customer_id
with rollup
having sum(payment.amount) > 200;

-- M 

select rental_id, customer_id, sum(amount), payment_date
from payment
group by rental_id;
