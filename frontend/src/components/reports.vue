<template>
  <div class="Reports">
    <h1>Rapporter tilgjengelig for deg</h1>
    <div class="content">
        <div class="mycard">
            <b-card-group deck>
                <b-card title="Top 10 serier" class="white_card">
                    <b-card-text>
                        <div>Denne viser deg de 10 seriene som har best rating</div>
                    </b-card-text>
                    <div slot="footer">
                        <b-button variant="info">Last ned</b-button>
                    </div>
                </b-card>
                
                <b-card title="Sammndrag av serier" class="white_card">
                    <b-card-text>
                        <div>Denne viser sammendrag av seriene</div>
                    </b-card-text>
                    <div slot="footer">
                        <b-button href="#" variant="info">Last ned</b-button>
                    </div>
                </b-card>
            </b-card-group>
        </div>
    </div>
  </div>
</template>

<script>

export default {
  name: 'Reports',
  data() {      
      return{
          file:[]
      }
  }
}

</script>

<style lang="scss">
.card{
    .btn-info {
        font-size: 16px;
        font-weight: 600;;
        color: #112f52;
        background-color: #ffffff;
        border-color: #e2e9f1;
    }
}
</style>

