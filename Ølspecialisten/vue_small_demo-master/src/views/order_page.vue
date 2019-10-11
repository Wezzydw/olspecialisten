<template>
    <main>

        <div id="main_container_4">
            <div id="order_title">
                <h2>Bestilling</h2>
            </div>
            <div id="order_container">
                <div id="order_info">
                    <form action="/order_page.html">
                        <fieldset>
                            <legend>Personlige oplysninger</legend>
                            Navn:<br>
                            <input type="text" name="Navn" value="">
                            <br><br>
                            Efternavn:<br>
                            <input type="text" name="Efternavn" value="">
                            <br> <br>
                        </fieldset>
                        <fieldset>
                            <legend> Lokation</legend>
                            By: <br>
                            <input type="text" name="By" value="">
                            <br><br>
                            Postnummer: <br>
                            <input type="text" name="Postnummer" value="">
                            <br><br>
                            Adresse <br>
                            <input type="text" name="Adresse" value="">
                            <br><br>
                        </fieldset>
                        <fieldset>
                            <legend> Kontakt </legend>
                            Telefon<br>
                            <input type="text" name="Telefon" value="">
                            <br><br>
                            E-mail<br>
                            <input type="text" name="email" value="">
                        </fieldset>
                        <fieldset>
                            <legend> Betalingsmetode </legend>
                            <select name="Betalingsmetode">
                                <option value="blank"></option>
                                <option value="Visa/Dankort">Visa/Dankort</option>
                                <option value="PayPal">PayPal</option>
                                <option value="MobilePay">Mobilepay</option>
                            </select>
                        </fieldset>
                        <br>
                        <input type="submit" value="Bestil">
                    </form>
                </div>
                <div id="order_overview">
                    <p>Produktbeskrivelse</p>
                </div>
            </div>
        </div>

    </main>
</template>

<script>
    export default {
        name: "order_page"
    }
</script>

<style scoped>

</style>