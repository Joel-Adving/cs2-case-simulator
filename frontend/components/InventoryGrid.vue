<script setup lang="ts">
import type { InventoryItem } from '~/services/inventoryDb';
import Image from './Image.vue';
const props = defineProps<{
    items: InventoryItem[];
    inventoryView?: boolean;
}>();

const getSkinKey = (item: InventoryItem, index: number) => {
    return `${item.item_id || ''}${item.name}${item.wear_category || ''}${index}`;
};
</script>

<template>
    <div class="rounded-sm gap-3 gap-y-2 sm:gap-y-3 responsive-grid">
        <div v-for="(item, i) in props.items" :key="getSkinKey(item, i)" class="max-w-[133px]">
            <div class="bg-black/30 rounded-md duration-75 hover:shadow-xl border border-black/10">
                <div class="border-b-5 relative p-1 rounded-[5px]" :style="{ borderColor: getItemRarityColor(item) }">
                    <Image
                        :key="getSkinKey(item, i) + '-img'"
                        :width="160"
                        :height="120"
                        :src="item?.image ?? '/images/placeholder.webp'"
                        :alt="item?.name"
                        class-name="transition-transform duration-75 hover:scale-[133%] pb-4 p-0 m-0"
                    ></Image>

                    <div
                        v-if="item.price && item.price > 0"
                        class="absolute flex justify-end w-full bottom-0 right-0 text-green-400 pb-0.5 text-xs bg-black/20 px-1"
                    >
                        {{ formatEuro(item.price) }}
                    </div>
                </div>
            </div>
            <div class="flex flex-col justify-between mt-1">
                <p class="text-xs font-semibold text-left text-white/85">{{ item.name }}</p>

                <span v-if="item.wear_category !== 'Default'" class="text-nowrap text-xs text-white/70"
                    >{{ item.wear_category }}
                </span>
            </div>
        </div>
    </div>
</template>
