<script setup lang="ts">
import CrateGrid from '~/components/CrateGrid.vue';
import CrateNav from '~/components/CrateNav.vue';
import SearchCrates from '~/components/SearchCrates.vue';
import { useAutographPageSeo } from '~/services/metaSeoService';
import { useCrateList } from '~/composables/useCrateList';

const { data, searchData, crates } = useCrateList('autographs');

if (data.value) {
    useAutographPageSeo(data.value);
}
</script>

<template>
    <Container>
        <div>
            <div class="px-4 pt-2 sm:pt-0">
                <h1 class="text-xl pb-4">Counter-Strike 2 Autograph Capsules</h1>
                <div class="flex gap-4 flex-col">
                    <SearchCrates v-model="searchData"></SearchCrates>
                    <CrateNav active-link="Autographs"></CrateNav>
                </div>
                <CrateGrid v-bind="{ crates }"></CrateGrid>
            </div>
        </div>
    </Container>
</template>
