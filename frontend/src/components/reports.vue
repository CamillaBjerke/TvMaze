<template>
  <div class="Reports">
    <h1>Rapporter tilgjengelig for deg</h1>
    <div class="mycard">
        <b-card-group deck>
            <b-card title="Top 10 serier" sub-title="Denne viser deg de 10 seriene som har best rating">
                <b-card-text>
                </b-card-text>
                <div slot="footer">
                    <b-button href="#" variant="primary">Last ned</b-button>
                </div>
            </b-card>
            
            <b-card title="Sammndrag av serier" sub-title="Denne viser sammendrag av seriene">
                <b-card-text>
                </b-card-text>
                <div slot="footer">
                    <b-button href="#" variant="primary">Last ned</b-button>
                </div>
            </b-card>
        </b-card-group>
    </div>
  </div>
</template>

<script>
</script>

<style lang="scss">
    .mycard{
        margin-top: 50px;
        display: flex;
        justify-content: center;
    }
</style>

